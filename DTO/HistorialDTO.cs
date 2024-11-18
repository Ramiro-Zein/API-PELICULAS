using System.ComponentModel.DataAnnotations;
using API_PELICULAS.Models;

namespace API_PELICULAS.DTO;

public class HistorialDTO
{
    [Key] public Guid IdHistorial { get; set; }
    public DateOnly FechaVista { get; set; }
    public PeliculaDTO Pelicula { get; set; }
}