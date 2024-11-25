using System.Security.Claims;
using API_PELICULAS.DataAccess.Interfaces;
using API_PELICULAS.Database;
using API_PELICULAS.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.DataAccess.Repositories;

public class Auth(PeliculasDbContext context, IHttpContextAccessor httpContextAccessor) : IAuth
{
    public async Task<bool> ValidarUsuario(string nombreUsuario, string clave)
    {
        var usuario = await context.Usuarios
            .FirstOrDefaultAsync(u => u.NombreUsuario == nombreUsuario && u.EstatusUsuario == Usuario.Estatus.Activo);

        if (usuario == null || !BCrypt.Net.BCrypt.Verify(clave, usuario.ClaveUsuario)) return false;

        // Configurar cookies de autenticación
        var claims = new List<Claim> { new Claim(ClaimTypes.Name, usuario.NombreUsuario) };
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        await httpContextAccessor.HttpContext!.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
            new ClaimsPrincipal(identity));

        return true;
    }

    public async Task CerrarSesion()
    {
        await httpContextAccessor.HttpContext!.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}