using System.ComponentModel.DataAnnotations;
using API_PELICULAS.Models;

namespace API_PELICULAS.DTO;

public class PeliculaDTO
{
    [Key] public Guid IdPelicula { get; set; }
    public string TituloPelicula { get; set; }
    public TimeOnly DuracionPelicula { get; set; }
    public string DescripcionPelicula { get; set; }
    public int ClasificacionPelicula { get; set; }
    public GeneroDTO GeneroPelicula { get; set; }
}