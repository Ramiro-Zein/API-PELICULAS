namespace API_PELICULAS.Models;

public class Historial
{
    public Guid IdHistorial { get; set; }
    public Guid IdPelicula { get; set; }
    public Guid IdUsuario { get; set; }
    public DateOnly FechaVista { get; set; }
}