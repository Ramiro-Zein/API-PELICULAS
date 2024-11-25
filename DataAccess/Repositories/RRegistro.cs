using API_PELICULAS.DataAccess.Interfaces;
using API_PELICULAS.Database;
using API_PELICULAS.DTO;
using API_PELICULAS.Models;

namespace API_PELICULAS.DataAccess.Repositories;

public class RRegistro(PeliculasDbContext context) : IRegistro
{
    public async Task<string> RegistrarUsuarioAsync(UsuarioDto usuarioDto)
    {
        if (context.Usuarios.Any(u => u.NombreUsuario == usuarioDto.NombreUsuario))
        {
            return "El usuario ya existe";
        }

        var usuario = new Usuario
        {
            IdUsuario = Guid.NewGuid(),
            NombreUsuario = usuarioDto.NombreUsuario,
            ClaveUsuario = BCrypt.Net.BCrypt.HashPassword(usuarioDto.ClaveUsuario),
            EstatusUsuario = Usuario.Estatus.Activo
        };

        await context.Usuarios.AddAsync(usuario);
        await context.SaveChangesAsync();

        var historial = new Historial
        {
            IdHistorial = Guid.NewGuid(),
            IdPelicula = context.Peliculas.First().IdPelicula,
            IdUsuario = usuario.IdUsuario,
            FechaVista = DateOnly.FromDateTime(DateTime.Now)
        };

        await context.Historiales.AddAsync(historial);
        await context.SaveChangesAsync();

        return "Usuario registrado exitosamente";
    }
}
