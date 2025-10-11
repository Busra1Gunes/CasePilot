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

// ============================================
// AUTOFAC CONFIGURATION
// ============================================
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(containerBuilder =>
    {
        containerBuilder.RegisterModule(new AutofacBusinessModule());
    });

// ============================================
// DATABASE CONFIGURATION
// ============================================
builder.Services.AddDbContext<CasePilotContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// UnitOfWork Registration
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

// ============================================
// AUTOMAPPER CONFIGURATION
// ============================================
builder.Services.AddAutoMapper(typeof(MapProfile));
builder.Services.AddHttpContextAccessor();

// ============================================
// FILE STORAGE CONFIGURATION - YENİ EKLENDI
// ============================================
// FileStorage ayarlarını appsettings.json'dan oku
builder.Services.Configure<FileStorageSettings>(
    builder.Configuration.GetSection("FileStorage"));

// FileService'i kaydet
builder.Services.AddScoped<IFileService>(provider =>
{
    var uploadPath = Path.Combine(
        Directory.GetCurrentDirectory(),
        "wwwroot",
    "uploads",
        "documents");
    return new FileManager(uploadPath);
});

// ============================================
// JWT AUTHENTICATION
// ============================================
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

// ============================================
// CORS CONFIGURATION
// ============================================
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

// ============================================
// SWAGGER CONFIGURATION
// ============================================
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "CasePilot API",
        Version = "v1",
        Description = "Avukatlık Bürosu Yönetim Sistemi API Dokümantasyonu"
    });

    // JWT Authentication için Swagger yapılandırması
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    c.AddSecurityRequirement(new OpenApiSecurityRequirement
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
            Array.Empty<string>()
        }
    });

    // Swagger operasyon açıklamalarını etkinleştir
    c.EnableAnnotations();
});

// ============================================
// CONTROLLERS & JSON OPTIONS
// ============================================
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        // JSON serileştirme sırasında referans döngülerini yoksay
        options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
        options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
    });

builder.Services.AddEndpointsApiExplorer();

// ============================================
// MEMORY CACHE (optional)
// ============================================
builder.Services.AddMemoryCache();

// ============================================
// APP BUILD
// ============================================
var app = builder.Build();

// ============================================
// MIDDLEWARE PIPELINE
// ============================================

// Swagger - Development ve Production için
if (app.Environment.IsDevelopment() || app.Environment.IsProduction())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CasePilot API V1");
        c.RoutePrefix = "swagger"; // https://localhost:7205/swagger
    });
}

// HTTPS Redirection
app.UseHttpsRedirection();

// STATIC FILES - DOSYA ERİŞİMİ İÇİN ÖNEMLİ!
app.UseStaticFiles(); // wwwroot klasörünü web'e aç

// CORS
app.UseCors("AllowAll");

// AUTHENTICATION & AUTHORIZATION
app.UseAuthentication();
app.UseAuthorization();

// CONTROLLERS
app.MapControllers();

// ============================================
// UYGULAMA BAŞLATMA MESAJI
// ============================================
app.Logger.LogInformation("CasePilot API Started!");
app.Logger.LogInformation($"Environment: {app.Environment.EnvironmentName}");
app.Logger.LogInformation($"Swagger UI: https://localhost:7205/swagger");

app.Run();
