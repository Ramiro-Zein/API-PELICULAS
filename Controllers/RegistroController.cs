using API_PELICULAS.DataAccess.Repositories;
using API_PELICULAS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RegistroController(RRegistro rRegistro) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> RegistrarUsuario([FromBody] UsuarioDto usuarioDto)
    {
        try
        {
            var resultado = await rRegistro.RegistrarUsuarioAsync(usuarioDto);
            if (resultado == "El usuario ya existe")
            {
                return BadRequest(new { mensaje = resultado });
            }

            return Ok(new { mensaje = resultado });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }
}
