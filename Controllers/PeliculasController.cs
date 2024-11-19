using API_PELICULAS.DataAccess.Repositories;
using API_PELICULAS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeliculasController(RPelicula rPelicula) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PeliculaDTO>>> GetAlumnos()
    {
        try
        {
            return await rPelicula.GetAllAsync();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }
}