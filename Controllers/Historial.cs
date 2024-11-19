using API_PELICULAS.Database;
using API_PELICULAS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Historial(PeliculasDbContext context) : Controller
{
    [HttpPost]
    [Route("agregar")]
    public async Task<IActionResult> AgregarHistorial([FromBody] HistorialRequest request)
    {

        var usuario = await context.Usuarios.FindAsync(request.IdUsuario);
        var pelicula = await context.Peliculas.FindAsync(request.IdPelicula);

        if (usuario == null)
        {
            return NotFound(new { mensaje = "El usuario no existe." });
        }

        if (pelicula == null)
        {
            return NotFound(new { mensaje = "La película no existe." });
        }
            
        var nuevoHistorial = new Models.Historial
        {
            IdHistorial = Guid.NewGuid(),
            IdUsuario = request.IdUsuario,
            IdPelicula = request.IdPelicula,
            FechaVista = DateOnly.FromDateTime(DateTime.UtcNow)
        };

        context.Historiales.Add(nuevoHistorial);
        await context.SaveChangesAsync();

        return Ok(new
        {
            mensaje = "Registro agregado exitosamente.",
            historial = nuevoHistorial
        });
    }
}