using System.ComponentModel.DataAnnotations;

namespace API_PELICULAS.Models;

public class Pelicula
{
    [Key] public Guid IdPelicula { get; set; }
    [Required] public string TituloPelicula { get; set; }
    [Required] public TimeOnly DuracionPelicula { get; set; }
    [Required] public string DescripcionPelicula { get; set; }
    [Required] public int ClasificacionPelicula { get; set; }
    
    public Genero? GeneroPelicula { get; set; }
    public Guid IdGenero { get; set; }
    public ICollection<PeliculaGenero> PeliculaGeneros { get; set; }
}