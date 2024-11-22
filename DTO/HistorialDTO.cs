using System.ComponentModel.DataAnnotations;

namespace API_PELICULAS.DTO;

public class HistorialDTO
{
    [Key] public Guid IdHistorial { get; set; }
    public Guid IdUsuario { get; set; }
    public Guid IdPelicula { get; set; }
    public PeliculaDTO Pelicula { get; set; }
    public DateOnly FechaVista { get; set; }
}