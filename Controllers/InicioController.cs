using API_PELICULAS.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_PELICULAS.Controllers;

[ApiController]
[Route("/")]
public class InicioController : Controller
{
    public IActionResult Index()
    {
        var mensaje = new Bienvenido
        {
            Mensaje = "Bienvenido a la API de peliculas"
        };
        
        return Json(mensaje);
    }
}