using System.ComponentModel.DataAnnotations;

namespace API_PELICULAS.DTO;

public class GeneroDTO
{
    [Key] public Guid IdGenero { get; set; }
    public IEnumerable<string> NombreGenero { get; set; }
}