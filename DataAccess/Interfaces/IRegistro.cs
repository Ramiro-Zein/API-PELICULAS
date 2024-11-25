using API_PELICULAS.DTO;

namespace API_PELICULAS.DataAccess.Interfaces;

public interface IRegistro
{
    Task<string> RegistrarUsuarioAsync(UsuarioDto usuarioDto);
}
