namespace API_PELICULAS.DataAccess.Interfaces;

public interface IAuth
{
    Task<bool> ValidarUsuario(string nombreUsuario, string clave);
    Task CerrarSesion();
}