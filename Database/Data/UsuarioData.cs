using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace API_PELICULAS.Database.Data;

public class UsuarioData : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasData(
            new Usuario
            {
                IdUsuario = Guid.Parse("56789012-5678-5678-5678-5678901234ef"),
                NombreUsuario = "ramiro.zein",
                ClaveUsuario = BCrypt.Net.BCrypt.HashPassword("1234"),
                EstatusUsuario = Usuario.Estatus.Activo
            },
            new Usuario
            {
                IdUsuario = Guid.Parse("67890123-6789-6789-6789-6789012345f0"),
                NombreUsuario = "maria.lopez",
                ClaveUsuario = BCrypt.Net.BCrypt.HashPassword("nel"),
                EstatusUsuario = Usuario.Estatus.Activo
            }
        );
    }
}