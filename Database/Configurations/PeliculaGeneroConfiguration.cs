using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_PELICULAS.Database.Configurations;

public class PeliculaGeneroConfiguration : IEntityTypeConfiguration<PeliculaGenero>
{
    public void Configure(EntityTypeBuilder<PeliculaGenero> builder)
    {
        builder.HasKey(pg => new { pg.IdPelicula, pg.IdGenero });

        builder.HasOne(pg => pg.Pelicula)
            .WithMany(p => p.PeliculaGeneros)
            .HasForeignKey(pg => pg.IdPelicula);

        builder.HasOne(pg => pg.Genero)
            .WithMany(g => g.PeliculaGeneros)
            .HasForeignKey(pg => pg.IdGenero);
    }
}