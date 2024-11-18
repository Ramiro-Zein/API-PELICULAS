using API_PELICULAS.Database;
using API_PELICULAS.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class Peliculas(PeliculasDbContext context) : Controller
{
    public async Task<IActionResult> GetPeliculas()
    {
        var peliculas = await context.Peliculas
            .Select(p => new PeliculaDTO
            {
                IdPelicula = p.IdPelicula,
                TituloPelicula = p.TituloPelicula,
                DuracionPelicula = p.DuracionPelicula,
                DescripcionPelicula = p.DescripcionPelicula,
                ClasificacionPelicula = p.ClasificacionPelicula
            })
            .ToListAsync();
        return Ok(peliculas);
    }
}