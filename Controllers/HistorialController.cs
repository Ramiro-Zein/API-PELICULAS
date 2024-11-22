using API_PELICULAS.Database;
using API_PELICULAS.DTO;
using API_PELICULAS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HistorialController(PeliculasDbContext context) : Controller
{
    [HttpGet]
    public async Task<ActionResult<List<HistorialDTO>>> GetAllHistorial()
    {
        var historiales = await context.Historiales
            .Select(h => new HistorialDTO
            {
                IdHistorial = h.IdHistorial,
                IdPelicula = h.IdPelicula,
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
                        NombreGenero =
                            h.Pelicula.PeliculaGeneros.Select(g => g.Genero.NombreGenero.ToString())
                    }
                },
                IdUsuario = h.IdUsuario,
                FechaVista = h.FechaVista
            })
            .ToListAsync();

        return Ok(historiales);
    }

    [HttpGet("{idUsuario}")]
    public async Task<ActionResult<List<HistorialDTO>>> GetHistorialByUsuario(Guid idUsuario)
    {
        var historial = await context.Historiales
            .Where(a => a.IdUsuario == idUsuario)
            .Include(a => a.Pelicula)
            .Include(a => a.Usuario)
            .Select(h => new HistorialDTO
            {
                IdUsuario = h.IdUsuario,
                IdHistorial = h.IdHistorial,
                IdPelicula = h.IdPelicula,
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
                },
                FechaVista = h.FechaVista
            })
            .ToListAsync();

        return Ok(historial);
    }

    [HttpPost("agregar")]
    public async Task<IActionResult> AgregarHistorial([FromBody] HistorialRequest request)
    {
        var usuario = await context.Usuarios.FindAsync(request.IdUsuario);
        if (usuario == null)
        {
            return NotFound(new { mensaje = "Usuario no encontrado." });
        }

        var pelicula = await context.Peliculas.FindAsync(request.IdPelicula);
        if (pelicula == null)
        {
            return NotFound(new { mensaje = "Película no encontrada." });
        }

        var nuevoHistorial = new Historial
        {
            IdHistorial = Guid.NewGuid(),
            IdUsuario = request.IdUsuario,
            IdPelicula = request.IdPelicula,
            FechaVista = DateOnly.FromDateTime(DateTime.Now)
        };

        context.Historiales.Add(nuevoHistorial);
        await context.SaveChangesAsync();

        return Ok(new { mensaje = "Historial agregado exitosamente." });
    }

    [HttpDelete("{idHistorial}")]
    public async Task<IActionResult> EliminarHistorial(Guid idHistorial)
    {
        var historial = await context.Historiales.FindAsync(idHistorial);
        if (historial == null)
        {
            return NotFound(new { mensaje = "Historial no encontrado." });
        }

        context.Historiales.Remove(historial);
        await context.SaveChangesAsync();

        return Ok(new { mensaje = "Registro eliminado exitosamente." });
    }
}