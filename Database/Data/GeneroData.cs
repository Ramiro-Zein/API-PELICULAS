using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_PELICULAS.Database.Data;

public class GeneroData : IEntityTypeConfiguration<Genero>
{
    public void Configure(EntityTypeBuilder<Genero> builder)
    {
        builder.HasData(
            new Genero { IdGenero = Guid.Parse("12345678-1234-1234-1234-1234567890ab"), NombreGenero = Genero.GeneroPelicula.Accion },
            new Genero { IdGenero = Guid.Parse("23456789-2345-2345-2345-2345678901bc"), NombreGenero = Genero.GeneroPelicula.Comedia },
            new Genero { IdGenero = Guid.Parse("34567890-3456-3456-3456-3456789012cd"), NombreGenero = Genero.GeneroPelicula.Drama },
            new Genero { IdGenero = Guid.Parse("45678901-4567-4567-4567-4567890123de"), NombreGenero = Genero.GeneroPelicula.Romance },
            new Genero { IdGenero = Guid.Parse("56789012-5678-5678-5678-5678901234ef"), NombreGenero = Genero.GeneroPelicula.Terror },
            new Genero { IdGenero = Guid.Parse("67890123-6789-6789-6789-6789012345fa"), NombreGenero = Genero.GeneroPelicula.Fantasía },
            new Genero { IdGenero = Guid.Parse("78901234-7890-7890-7890-7890123456ac"), NombreGenero = Genero.GeneroPelicula.Documental },
            new Genero { IdGenero = Guid.Parse("89012345-8901-8901-8901-8901234567bd"), NombreGenero = Genero.GeneroPelicula.Musical },
            new Genero { IdGenero = Guid.Parse("90123456-9012-9012-9012-9012345678ce"), NombreGenero = Genero.GeneroPelicula.Aventura },
            new Genero { IdGenero = Guid.Parse("01234567-0123-0123-0123-0123456789df"), NombreGenero = Genero.GeneroPelicula.Thriller },
            new Genero { IdGenero = Guid.Parse("11234567-1123-1123-1123-1123456789ea"), NombreGenero = Genero.GeneroPelicula.Animación },
            new Genero { IdGenero = Guid.Parse("21234567-2123-2123-2123-2123456789fb"), NombreGenero = Genero.GeneroPelicula.Biografía },
            new Genero { IdGenero = Guid.Parse("31234567-3123-3123-3123-3123456789bc"), NombreGenero = Genero.GeneroPelicula.Deportes },
            new Genero { IdGenero = Guid.Parse("41234567-4123-4123-4123-4123456789cd"), NombreGenero = Genero.GeneroPelicula.Misterio }
        );
    }
}