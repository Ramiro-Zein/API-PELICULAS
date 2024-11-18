using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_PELICULAS.Database.Configurations;

public class HistorialConfiguration : IEntityTypeConfiguration<Historial>
{
    public void Configure(EntityTypeBuilder<Historial> builder)
    {
        builder.HasOne(h => h.Pelicula)
            .WithMany()
            .HasForeignKey(h => h.IdPelicula)
            .IsRequired();

        builder.HasOne(h => h.Usuario)
            .WithMany(u => u.Historiales)
            .HasForeignKey(h => h.IdUsuario)
            .IsRequired();
    }
}