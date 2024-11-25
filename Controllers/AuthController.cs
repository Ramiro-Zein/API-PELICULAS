using API_PELICULAS.DataAccess.Interfaces;
using API_PELICULAS.Database;
using API_PELICULAS.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(IAuth auth, PeliculasDbContext context) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginSolicitarDto respuesta)
    {
        if (!await auth.ValidarUsuario(respuesta.NombreUsuario, respuesta.ClaveUsuario))
            return Unauthorized("Credenciales incorrectas");

        var usuario = await context.Usuarios.FirstOrDefaultAsync(u =>
            EF.Functions.Collate(u.NombreUsuario, "Latin1_General_BIN") == respuesta.NombreUsuario);

        if (usuario == null) return Unauthorized("Credenciales incorrectas");

        var respuestaDto = new LoginRespuestaDto
        {
            Mensaje = "Bienvenido",
            NombreUsuario = usuario.NombreUsuario,
            IdUsuario = usuario.IdUsuario
        };

        return Ok(respuestaDto);
    }

    [HttpPost("logout")]
    public async Task<IActionResult> Logout()
    {
        await auth.CerrarSesion();
        return Ok("Sesión cerrada.");
    }
}