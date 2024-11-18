using API_PELICULAS.DatabaseContext;
using API_PELICULAS.DTO;
using API_PELICULAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsuarioTest(PeliculasDbContext context) : Controller
{
    [HttpGet("{idUsuario}")]
    public async Task<ActionResult<UsuarioRespuestaDTO>> GetUsuarioById(Guid idUsuario)
    {
        var usuarios = await context.Usuarios
            .Where(u => u!.IdUsuario == idUsuario)
            .Where(u => u!.Historiales.Any())
            .Select(u => new UsuarioRespuestaDTO
            {
                IdUsuario = u!.IdUsuario,
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
            .ToListAsync();

        return Ok(usuarios);
    }

}