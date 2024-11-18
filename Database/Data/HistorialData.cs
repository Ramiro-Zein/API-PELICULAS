using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_PELICULAS.Database.Data;

public class HistorialData : IEntityTypeConfiguration<Historial>
{
    public void Configure(EntityTypeBuilder<Historial> builder)
    {
        var usuario1Guid = Guid.Parse("56789012-5678-5678-5678-5678901234ef");
        var usuario2Guid = Guid.Parse("67890123-6789-6789-6789-6789012345f0");
        
        var pelicula1Guid = Guid.Parse("78901234-7890-7890-7890-7890123456a1");
        var pelicula2Guid = Guid.Parse("89012345-8901-8901-8901-8901234567b2");
        var pelicula3Guid = Guid.Parse("90123456-9012-9012-9012-9012345678c3");
        var pelicula4Guid = Guid.Parse("12345678-5678-1234-1234-5678901234de");
        
        builder.HasData(
            new Historial
            {
                IdHistorial = Guid.Parse("01234567-0123-0123-0123-0123456789d4"),
                IdPelicula = pelicula1Guid,
                IdUsuario = usuario1Guid,
                FechaVista = new DateOnly(2024, 1, 15)
            },
            new Historial
            {
                IdHistorial = Guid.Parse("11234567-1123-1123-1123-1123456789e5"),
                IdPelicula = pelicula2Guid,
                IdUsuario = usuario1Guid,
                FechaVista = new DateOnly(2024, 2, 20)
            },
            new Historial
            {
                IdHistorial = Guid.Parse("21234567-2123-2123-2123-2123456789f6"),
                IdPelicula = pelicula3Guid,
                IdUsuario = usuario2Guid,
                FechaVista = new DateOnly(2024, 3, 10)
            },
            new Historial
            {
                IdHistorial = Guid.Parse("31234567-3123-3123-3123-3123456789a7"),
                IdPelicula = pelicula1Guid,
                IdUsuario = usuario2Guid,
                FechaVista = new DateOnly(2024, 4, 5)
            },
            new Historial
            {
                IdHistorial = Guid.Parse("9ab2c456-9012-9012-9012-9012345678c3"),
                IdPelicula = pelicula4Guid,
                IdUsuario = usuario1Guid,
                FechaVista = new DateOnly(2020, 9, 4)
            }

        );
    }
}