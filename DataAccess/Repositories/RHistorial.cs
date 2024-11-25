using API_PELICULAS.DataAccess.Interfaces;
using API_PELICULAS.Database;
using API_PELICULAS.DTO;
using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.DataAccess.Repositories;

public class RHistorial(PeliculasDbContext context) : IHistorial
{
    public async Task<List<HistorialDTO>> GetAllHistorialAsync()
    {
        return await context.Historiales
            .Select(h => new HistorialDTO
            {
                IdHistorial = h.IdHistorial,
                IdPelicula = h.IdPelicula,
                Pelicula = new PeliculaDTO
                {
                    IdPelicula = h.Pelicula.IdPelicula,
                    TituloPelicula = h.Pelicula.TituloPelicula,
                    DuracionPelicula = h.Pelicula.DuracionPelicula,
                    DescripcionPelicula = h.Pelicula.DescripcionPelicula,
                    ClasificacionPelicula = h.Pelicula.ClasificacionPelicula,
                    GeneroPelicula = new GeneroDTO
                    {
                        IdGenero = h.Pelicula.IdGenero,
                        NombreGenero = h.Pelicula.PeliculaGeneros.Select(g => g.Genero.NombreGenero.ToString())
                    }
                },
                IdUsuario = h.IdUsuario,
                FechaVista = h.FechaVista
            })
            .ToListAsync();
    }

    public async Task<List<HistorialDTO>> GetHistorialByUsuarioAsync(Guid idUsuario)
    {
        return await context.Historiales
            .Where(h => h.IdUsuario == idUsuario)
            .Select(h => new HistorialDTO
            {
                IdHistorial = h.IdHistorial,
                IdPelicula = h.IdPelicula,
                Pelicula = new PeliculaDTO
                {
                    IdPelicula = h.Pelicula.IdPelicula,
                    TituloPelicula = h.Pelicula.TituloPelicula,
                    DuracionPelicula = h.Pelicula.DuracionPelicula,
                    DescripcionPelicula = h.Pelicula.DescripcionPelicula,
                    ClasificacionPelicula = h.Pelicula.ClasificacionPelicula,
                    GeneroPelicula = new GeneroDTO
                    {
                        IdGenero = h.Pelicula.IdGenero,
                        NombreGenero = h.Pelicula.PeliculaGeneros.Select(g => g.Genero.NombreGenero.ToString())
                    }
                },
                IdUsuario = h.IdUsuario,
                FechaVista = h.FechaVista
            })
            .ToListAsync();
    }

    public async Task<string> AgregarHistorialAsync(HistorialRequest request)
    {
        var usuario = await context.Usuarios.FindAsync(request.IdUsuario);
        if (usuario == null) return "Usuario no encontrado.";

        var pelicula = await context.Peliculas.FindAsync(request.IdPelicula);
        if (pelicula == null) return "Película no encontrada.";

        var nuevoHistorial = new Historial
        {
            IdHistorial = Guid.NewGuid(),
            IdUsuario = request.IdUsuario,
            IdPelicula = request.IdPelicula,
            FechaVista = DateOnly.FromDateTime(DateTime.Now)
        };

        context.Historiales.Add(nuevoHistorial);
        await context.SaveChangesAsync();

        return "Historial agregado exitosamente.";
    }

    public async Task<string> EliminarHistorialAsync(Guid idHistorial)
    {
        var historial = await context.Historiales.FindAsync(idHistorial);
        if (historial == null) return "Historial no encontrado.";

        context.Historiales.Remove(historial);
        await context.SaveChangesAsync();

        return "Registro eliminado exitosamente.";
    }
}
