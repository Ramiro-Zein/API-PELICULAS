using API_PELICULAS.DTO;

namespace API_PELICULAS.DataAccess.Interfaces;

public interface IPelicula
{
    Task<List<PeliculaDTO>> GetAllAsync();
}