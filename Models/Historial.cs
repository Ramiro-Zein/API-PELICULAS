using System.ComponentModel.DataAnnotations;

namespace API_PELICULAS.Models;

public class Historial
{
    [Key] public Guid IdHistorial { get; set; }
    public Guid IdPelicula { get; set; }
    public Pelicula Pelicula { get; set; }
    public Guid IdUsuario { get; set; }
    public Usuario Usuario { get; set; }
    public DateOnly FechaVista { get; set; }
}