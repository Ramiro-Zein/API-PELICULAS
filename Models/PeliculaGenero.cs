using System.ComponentModel.DataAnnotations;

namespace API_PELICULAS.Models;

public class PeliculaGenero
{
    [Key] public Guid IdPelicula { get; set; }
    public Pelicula Pelicula { get; set; } = null!;

    public Guid IdGenero { get; set; }
    public Genero Genero { get; set; } = null!;
}