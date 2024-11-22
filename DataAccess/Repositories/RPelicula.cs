using API_PELICULAS.DataAccess.Interfaces;
using API_PELICULAS.Database;
using API_PELICULAS.DTO;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.DataAccess.Repositories;

public class RPelicula(PeliculasDbContext context) : IPelicula
{
    public async Task<List<PeliculaDTO>> GetAllAsync()
    {
        var peliculas = await context.Peliculas.Select(p => new PeliculaDTO
        {
            IdPelicula = p.IdPelicula,
            TituloPelicula = p.TituloPelicula,
            DuracionPelicula = p.DuracionPelicula,
            DescripcionPelicula = p.DescripcionPelicula,
            ClasificacionPelicula = p.ClasificacionPelicula
        }).ToListAsync();

        return peliculas;
    }
}