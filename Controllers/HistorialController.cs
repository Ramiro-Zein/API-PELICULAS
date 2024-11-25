using API_PELICULAS.DataAccess.Repositories;
using API_PELICULAS.DTO;
using Microsoft.AspNetCore.Mvc;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HistorialController(RHistorial rHistorial) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<List<HistorialDTO>>> GetAllHistorial()
    {
        return Ok(await rHistorial.GetAllHistorialAsync());
    }

    [HttpGet("{idUsuario}")]
    public async Task<ActionResult<List<HistorialDTO>>> GetHistorialByUsuario(Guid idUsuario)
    {
        return Ok(await rHistorial.GetHistorialByUsuarioAsync(idUsuario));
    }

    [HttpPost("agregar")]
    public async Task<IActionResult> AgregarHistorial([FromBody] HistorialRequest request)
    {
        var resultado = await rHistorial.AgregarHistorialAsync(request);
        if (resultado.Contains("no encontrado")) return NotFound(new { mensaje = resultado });

        return Ok(new { mensaje = resultado });
    }

    [HttpDelete("{idHistorial}")]
    public async Task<IActionResult> EliminarHistorial(Guid idHistorial)
    {
        var resultado = await rHistorial.EliminarHistorialAsync(idHistorial);
        if (resultado.Contains("no encontrado")) return NotFound(new { mensaje = resultado });

        return Ok(new { mensaje = resultado });
    }
}
