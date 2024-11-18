using API_PELICULAS.Database;
using API_PELICULAS.DTO;
using API_PELICULAS.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegistroController(PeliculasDbContext _context) : Controller
{
    [HttpPost]
    public async Task<IActionResult> RegistrarUsuario([FromBody] UsuarioDto usuarioDto)
    {
        if (_context.Usuarios.Any(u => u.NombreUsuario == usuarioDto.NombreUsuario))
        {
            return BadRequest(new { mensaje = "El usuario ya existe" });
        }

        var usuario = new Usuario
        {
            IdUsuario = Guid.NewGuid(),
            NombreUsuario = usuarioDto.NombreUsuario,
            ClaveUsuario = BCrypt.Net.BCrypt.HashPassword(usuarioDto.ClaveUsuario),
            EstatusUsuario = Usuario.Estatus.Activo
        };

        await _context.Usuarios.AddAsync(usuario);
        await _context.SaveChangesAsync();

        var historial = new Models.Historial
        {
            IdHistorial = Guid.NewGuid(),
            IdPelicula = _context.Peliculas.First().IdPelicula,
            IdUsuario = usuario.IdUsuario,
            FechaVista = DateOnly.FromDateTime(DateTime.Now)
        };

        await _context.Historiales.AddAsync(historial);
        await _context.SaveChangesAsync();

        return Ok(new { mensaje = "Usuario registrado exitosamente" });
    }
}