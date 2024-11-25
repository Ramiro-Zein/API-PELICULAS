using API_PELICULAS.DataAccess.Repositories;
using API_PELICULAS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PeliculaController(RPelicula rPelicula) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<PeliculaDTO>>> GetAllPeliculas()
    {
        try
        {
            return await rPelicula.GetAllPeliculaAsync();
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<PeliculaDTO>> Get(Guid id)
    {
        try
        {
            return await rPelicula.GetByIdPeliculaAsync(id);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }
}