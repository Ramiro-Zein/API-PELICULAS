using System.Text.Json.Serialization;
using API_PELICULAS.DataAccess.Repositories;
using API_PELICULAS.Database;
using API_PELICULAS.Interfaces;
using API_PELICULAS.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace API_PELICULAS.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddProjectServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
        });

        // Configuración de Controladores y Opciones JSON
        services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
        });

        // Configuración de la base de datos
        services.AddDbContext<PeliculasDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<RPelicula>();

        // Configuración de Autenticación
        services.AddScoped<IAuthService, AuthService>();
        services.AddHttpContextAccessor();
        services.AddAuthentication("Cookies")
            .AddCookie(options =>
            {
                options.LoginPath = "/api/auth/login";
                options.LogoutPath = "/api/auth/logout";
                options.Cookie.HttpOnly = true;
            });

    }
}