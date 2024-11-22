using System.ComponentModel.DataAnnotations;

namespace API_PELICULAS.DTO;

public class HistorialRequest
{
    [Required] public Guid IdUsuario { get; set; }
    [Required] public Guid IdPelicula { get; set; }
}
