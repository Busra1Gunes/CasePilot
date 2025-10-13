using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Business.Settings;
using Core;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Service.Mapping;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// AUTOFAC
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
	.ConfigureContainer<ContainerBuilder>(containerBuilder =>
	{
		containerBuilder.RegisterModule(new AutofacBusinessModule());
	});

// DATABASE
builder.Services.AddDbContext<CasePilotContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// AUTOMAPPER
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddHttpContextAccessor();

// FILE STORAGE
builder.Services.Configure<FileStorageSettings>(
	builder.Configuration.GetSection("FileStorage"));



// JWT AUTHENTICATION
var jwtSettings = builder.Configuration.GetSection("JWT");
var secretKey = jwtSettings["SecurityKey"];

builder.Services.AddAuthentication(options =>
{
	options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
	options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
	options.TokenValidationParameters = new TokenValidationParameters
	{
		ValidateIssuer = true,
		ValidateAudience = true,
		ValidateLifetime = true,
		ValidateIssuerSigningKey = true,
		ValidIssuer = jwtSettings["Issuer"],
		ValidAudience = jwtSettings["Audience"],
		IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
		ClockSkew = TimeSpan.Zero
	};
});

// CORS
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllowAll",
		builder =>
		{
			builder.AllowAnyOrigin()
				   .AllowAnyMethod()
				   .AllowAnyHeader();
		});
});

// SWAGGER
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo
	{
		Title = "CasePilot API",
		Version = "v1",
		Description = "Avukatlık Bürosu Yönetim Sistemi API"
	});

    // JWT Authentication için Swagger yapılandırması
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,  // ✅ ApiKey yerine Http
        Scheme = "Bearer",               // ✅ Küçük harf "bearer" yerine "Bearer"
        BearerFormat = "JWT"             // ✅ Yeni eklendi
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"  // ✅ "bearer" yerine "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });

    c.EnableAnnotations();
});
// ============================================
// CONTROLLERS & JSON OPTIONS
// ============================================
builder.Services.AddControllers()
	.AddJsonOptions(options =>
	{
		options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
		options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
	});

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMemoryCache();

var app = builder.Build();

// SWAGGER
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CasePilot API V1");
        c.RoutePrefix = "swagger"; // https://localhost:7285/swagger
    });
}

// MIDDLEWARE PIPELINE
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseCors("AllowAll");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

// STARTUP LOG
app.Logger.LogInformation("CasePilot API Started!");
app.Logger.LogInformation($"Environment: {app.Environment.EnvironmentName}");
app.Logger.LogInformation($"Swagger UI: https://localhost:7285/swagger");

app.Run();