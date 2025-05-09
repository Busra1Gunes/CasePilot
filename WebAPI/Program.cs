using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Core.Aspects;
using Core.FTP;
using Core.Utilities.IoC;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Service.Mapping;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped(provider =>
{
    var httpContextAccessor = provider.GetRequiredService<IHttpContextAccessor>();
    var mapperConfiguration = new MapperConfiguration(cfg =>
    {
        cfg.AddProfile(new MapProfile(httpContextAccessor));
    });

    return mapperConfiguration.CreateMapper();
});
builder.Services.AddDbContext<CaseFileContext>();
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);
// Add services to the container.
builder.Services.AddControllers();
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

    // Custom Header tanýmý (örneðin x-api-key)
    opt.AddSecurityDefinition("CustomHeader", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "x-api-key", // Header adý
        Description = "Custom header for API key",
        Type = SecuritySchemeType.ApiKey
    });


    opt.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id="Bearer"
                }
            },
            new string[]{}
        }
    });
});






//Bu kod:JWT bearer authentication sistemini tanımlar.

//app.UseAuthentication(); satırının işe yaraması için gerekli olan ayarları yapar.

//JWT içeriğini appsettings.json dosyasından alır.

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



builder.Host.UseServiceProviderFactory(services => new AutofacServiceProviderFactory()).
    ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutofacBusinessModule());
    });
builder.Services.AddCors(options =>
    options.AddDefaultPolicy(policy => policy
    .AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod())
);
builder.Services.Configure<FtpSettings>(builder.Configuration.GetSection("FtpSettings"));
builder.Services.AddControllers();
builder.Services.AddMemoryCache();
ServiceTool.Create(builder.Services);
var app = builder.Build();

app.UseCors();

// HTTPS yönlendirmesini development ortamında devre dışı bırak
if (!app.Environment.IsDevelopment())
{
    app.UseHttpsRedirection();
}
//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{

//}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "My Api v1");
});
app.UseCors();

//app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
