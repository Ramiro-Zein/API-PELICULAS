using API_PELICULAS.Database;
using API_PELICULAS.DTO;
using API_PELICULAS.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(IAuthService authService, PeliculasDbContext context) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginSolicitarDto respuesta)
    {
        if (!await authService.ValidarUsuario(respuesta.NombreUsuario, respuesta.ClaveUsuario))
            return Unauthorized("Credenciales incorrectas");

        var usuario = await context.Usuarios.FirstOrDefaultAsync(u =>
                EF.Functions.Collate(u.NombreUsuario, "Latin1_General_BIN") == respuesta.NombreUsuario);

        if (usuario == null) return Unauthorized("Credenciales incorrectas");

        var respuestaDto = new LoginRespuestaDto
        {
            Mensaje = "Bienvenido",
            NombreUsuario = usuario.NombreUsuario,
            Historial = await context.Usuarios
                .Where(u => u.IdUsuario == usuario.IdUsuario)
                .Where(u => u.Historiales.Any())
                .Select(u => new UsuarioRespuestaDTO
                {
                    IdUsuario = u.IdUsuario,
                    NombreUsuario = u.NombreUsuario,
                    Historiales = u.Historiales
                        .Select(h => new HistorialDTO
                        {
                            IdHistorial = h.IdHistorial,
                            FechaVista = h.FechaVista,
                            Pelicula = new PeliculaDTO
                            {
                                IdPelicula = h.Pelicula.IdPelicula,
                                TituloPelicula = h.Pelicula.TituloPelicula,
                                DuracionPelicula = h.Pelicula.DuracionPelicula,
                                DescripcionPelicula = h.Pelicula.DescripcionPelicula,
                                ClasificacionPelicula = h.Pelicula.ClasificacionPelicula,
                                GeneroPelicula = new GeneroDTO
                                {
                                    IdGenero = h.Pelicula.IdGenero,
                                    NombreGenero = h.Pelicula.PeliculaGeneros.Select(g => g.Genero.NombreGenero.ToString())
                                }
                            }
                        }).ToList()
                })
                .FirstOrDefaultAsync() // Asegura que solo devuelves el primer usuario encontrado
        };

        return Ok(respuestaDto);
    }

    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        await authService.CerrarSesion();
        return Ok("Sesión cerrada.");
    }
}