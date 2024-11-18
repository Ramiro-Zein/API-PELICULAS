using System.ComponentModel.DataAnnotations;
using API_PELICULAS.Models;

namespace API_PELICULAS.DTO;

public class UsuarioRespuestaDTO
{
    [Key] public Guid IdUsuario { get; set; }
    public string NombreUsuario { get; set; }
    public List<HistorialDTO> Historiales { get; set; }
}