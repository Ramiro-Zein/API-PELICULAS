using System.ComponentModel.DataAnnotations;

namespace API_PELICULAS.DTO;

public class LoginSolicitarDto
{
    [Required]
    public string NombreUsuario { get; set; }
    
    [Required]
    public string ClaveUsuario { get; set; }
}