using System.Security.Claims;
using API_PELICULAS.DatabaseContext;
using API_PELICULAS.Interfaces;
using API_PELICULAS.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.Services;

public class AuthService : IAuthService
{
    private readonly PeliculasDbContext _context;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public AuthService(PeliculasDbContext context, IHttpContextAccessor httpContextAccessor)
    {
        _context = context;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task<bool> ValidarUsuario(string nombreUsuario, string clave)
    {
        var usuario = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.NombreUsuario == nombreUsuario && u.EstatusUsuario == Usuario.Estatus.Activo);

        if (usuario == null || !BCrypt.Net.BCrypt.Verify(clave, usuario.ClaveUsuario)) return false;

        // Configurar cookies de autenticación
        var claims = new List<Claim> { new Claim(ClaimTypes.Name, usuario.NombreUsuario) };
        var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        await _httpContextAccessor.HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity));

        return true;
    }

    public async Task CerrarSesion()
    {
        await _httpContextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
    }
}