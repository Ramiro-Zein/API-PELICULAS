namespace API_PELICULAS.Models;

public class Pelicula
{
    public Guid IdPelicula { get; set; }
    public string TituloPelicula { get; set; }
    public TimeOnly DuracionPelicula { get; set; }
    public string DescripcionPelicula { get; set; }
    public int ClasificacionPelicula { get; set; }
    public Genero? GeneroPelicula { get; set; }
    public Guid IdGenero { get; set; }
}