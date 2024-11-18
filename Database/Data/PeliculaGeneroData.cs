using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_PELICULAS.Database.Data;

public class PeliculaGeneroData : IEntityTypeConfiguration<PeliculaGenero>
{
    public void Configure(EntityTypeBuilder<PeliculaGenero> builder)
    {
        builder.HasData(
            new { IdPelicula = Guid.Parse("78901234-7890-7890-7890-7890123456a1"), IdGenero = Guid.Parse("12345678-1234-1234-1234-1234567890ab") }, // Mad Max: Fury Road - Acción
            new { IdPelicula = Guid.Parse("89012345-8901-8901-8901-8901234567b2"), IdGenero = Guid.Parse("23456789-2345-2345-2345-2345678901bc") }, // Superbad - Comedia
            new { IdPelicula = Guid.Parse("90123456-9012-9012-9012-9012345678c3"), IdGenero = Guid.Parse("34567890-3456-3456-3456-3456789012cd") }, // The Shawshank Redemption - Drama
            new { IdPelicula = Guid.Parse("12345678-5678-1234-1234-5678901234de"), IdGenero = Guid.Parse("45678901-4567-4567-4567-4567890123de") }, // Titanic - Romance
            new { IdPelicula = Guid.Parse("23456789-6789-2345-2345-6789012345fe"), IdGenero = Guid.Parse("56789012-5678-5678-5678-5678901234ef") }, // The Conjuring - Terror
            new { IdPelicula = Guid.Parse("34567890-7890-3456-3456-7890123456af"), IdGenero = Guid.Parse("67890123-6789-6789-6789-6789012345fa") }, // The Lord of the Rings - Fantasía
            new { IdPelicula = Guid.Parse("45678901-8901-4567-4567-8901234567bf"), IdGenero = Guid.Parse("78901234-7890-7890-7890-7890123456ac") }, // March of the Penguins - Documental
            new { IdPelicula = Guid.Parse("56789012-9012-5678-5678-9012345678cf"), IdGenero = Guid.Parse("89012345-8901-8901-8901-8901234567bd") }, // La La Land - Musical
            new { IdPelicula = Guid.Parse("67890123-0123-6789-6789-0123456789df"), IdGenero = Guid.Parse("90123456-9012-9012-9012-9012345678ce") }, // Indiana Jones - Aventura
            new { IdPelicula = Guid.Parse("78901234-1234-7890-7890-1234567890ef"), IdGenero = Guid.Parse("01234567-0123-0123-0123-0123456789df") }  // Se7en - Thriller
        );
    }
}