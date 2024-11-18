using API_PELICULAS.Models;

namespace API_PELICULAS.DTO;

public class LoginRespuestaDto
{
    public string Mensaje { get; set; }
    public string NombreUsuario { get; set; }
    public UsuarioRespuestaDTO? Historial { get; set; }
}