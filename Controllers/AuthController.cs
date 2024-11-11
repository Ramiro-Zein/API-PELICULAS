using API_PELICULAS.DatabaseContext;
using API_PELICULAS.DTO;
using API_PELICULAS.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController(IAuthService authService, PeliculasDbContext context) : ControllerBase
{
    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] LoginSolicitarDto respuesta)
    {
        if (!await authService.ValidarUsuario(respuesta.NombreUsuario, respuesta.ClaveUsuario))
            return Unauthorized("Credenciales incorrectas");

        var usuario = await context.Usuarios
            .FirstOrDefaultAsync(u =>
                EF.Functions.Collate(u.NombreUsuario, "Latin1_General_BIN") == respuesta.NombreUsuario);

        if (usuario == null) return Unauthorized("Credenciales incorrectas");

        var respuestaDto = new LoginRespuestaDto
        {
            Mensaje = "Bienvenido",
            NombreUsuario = usuario.NombreUsuario
        };

        return Ok(respuestaDto);
    }
}