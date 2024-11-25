using API_PELICULAS.DTO;

namespace API_PELICULAS.DataAccess.Interfaces;

public interface IHistorial
{
    Task<List<HistorialDTO>> GetAllHistorialAsync();
    Task<List<HistorialDTO>> GetHistorialByUsuarioAsync(Guid idUsuario);
    Task<string> AgregarHistorialAsync(HistorialRequest request);
    Task<string> EliminarHistorialAsync(Guid idHistorial);
}
