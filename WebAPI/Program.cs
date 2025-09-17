using Autofac;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Business.DependencyResolvers.Autofac;
using Core.FTP;
using Core.Utilities.IoC;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Serilog;
using Service.Mapping;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Serilog
builder.Host.UseSerilog((context, config) =>
{
    config.ReadFrom.Configuration(context.Configuration);
});

// Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(containerBuilder =>
    {
        containerBuilder.RegisterModule(new AutofacBusinessModule());
    });

// Services
builder.Services.AddDbContext<CasePilotContext>();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers();
builder.Services.Configure<FtpSettings>(builder.Configuration.GetSection("FtpSettings"));
builder.Services.AddStackExchangeRedisCache(options =>
{
    options.Configuration = builder.Configuration.GetConnectionString("Redis");
});
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

// AutoMapper (profil bağımlı)
builder.Services.AddScoped(provider =>
{
    var httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
    var config = new MapperConfiguration(cfg =>
    {
        cfg.AddProfile(new MapProfile(httpContextAccessor));
    });
    return config.CreateMapper();
});

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opt =>
{
    opt.SwaggerDoc("v1", new OpenApiInfo { Title = "MyAPI", Version = "v1" });

    opt.EnableAnnotations();

    opt.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Description = "Please enter token",
        Name = "Authorization",
        Type = SecuritySchemeType.Http,
        BearerFormat = "JWT",
        Scheme = "bearer"
    });



    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    });
});

// JWT Authentication
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
        ValidIssuer = builder.Configuration["JWT:Issuer"],
        ValidAudience = builder.Configuration["JWT:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:SecurityKey"]))
    };
});

// CORS: Geliştirme/test ortamı için herkese izinli
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

// IoC
ServiceTool.Create(builder.Services);

var app = builder.Build();

// 🌐 Middleware Sırası Çok Önemli

// CORS önce routing'e göre devreye alınmalı

app.UseCors("AllowAll");

if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}
app.UseRouting();
// Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1");
});

// Statik dosyalar
app.UseStaticFiles();


// Kimlik Doğrulama ve Yetkilendirme
app.UseAuthentication();
app.UseAuthorization();

// Routing - controller endpointleri
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
