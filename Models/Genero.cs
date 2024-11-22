using System.ComponentModel.DataAnnotations;

namespace API_PELICULAS.Models;

public class Genero
{
    [Key] public Guid IdGenero { get; set; }
    [Required] public GeneroPelicula NombreGenero { get; set; }
    public ICollection<PeliculaGenero> PeliculaGeneros { get; set; } = null!;

    public enum GeneroPelicula
    {
        Accion,
        Romance,
        Comedia,
        Drama,
        Terror,
        Fantasía,
        Documental,
        Musical,
        Aventura,
        Thriller,
        Animación,
        Biografía,
        Deportes,
        Misterio
    }
}