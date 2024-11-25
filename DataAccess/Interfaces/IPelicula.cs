using API_PELICULAS.DTO;

namespace API_PELICULAS.DataAccess.Interfaces;

public interface IPelicula
{
    Task<PeliculaDTO> GetByIdPeliculaAsync(Guid id);
    Task<List<PeliculaDTO>> GetAllPeliculaAsync();
    
}