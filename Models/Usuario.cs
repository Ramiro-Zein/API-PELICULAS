using System.ComponentModel.DataAnnotations;

namespace API_PELICULAS.Models;

public class Usuario
{
    [Key] public Guid IdUsuario { get; set; }
    [Required] public string NombreUsuario { get; set; }
    [Required] public string ClaveUsuario { get; set; }
    [Required] public Estatus EstatusUsuario { get; set; }
    public ICollection<Historial> Historiales { get; set; }
    
    public enum Estatus
    {
        Inactivo,
        Activo
    }
}