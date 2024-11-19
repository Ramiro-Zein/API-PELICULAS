namespace API_PELICULAS.Interfaces;

public interface IAuthService
{
    Task<bool> ValidarUsuario(string nombreUsuario, string clave);
    Task CerrarSesion();
}