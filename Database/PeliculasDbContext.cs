using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.DatabaseContext;

public class PeliculasDbContext : DbContext
{
    public PeliculasDbContext(DbContextOptions<PeliculasDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario?> Usuarios { get; set; }
    public DbSet<Historial> Historiales { get; set; }
    public DbSet<Pelicula> Peliculas { get; set; }
    public DbSet<Genero> Generos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Relación muchos a muchos entre Pelicula y Género
        modelBuilder.Entity<PeliculaGenero>()
            .HasKey(pg => new { pg.IdPelicula, pg.IdGenero });

        modelBuilder.Entity<PeliculaGenero>()
            .HasOne(pg => pg.Pelicula)
            .WithMany(p => p.PeliculaGeneros)
            .HasForeignKey(pg => pg.IdPelicula);

        modelBuilder.Entity<PeliculaGenero>()
            .HasOne(pg => pg.Genero)
            .WithMany(g => g.PeliculaGeneros)
            .HasForeignKey(pg => pg.IdGenero);

        // Relación uno a muchos entre Usuario y Historial
        modelBuilder.Entity<Historial>()
            .HasOne(h => h.Pelicula)
            .WithMany()
            .HasForeignKey(h => h.IdPelicula)
            .IsRequired();

        modelBuilder.Entity<Historial>()
            .HasOne(h => h.Usuario)
            .WithMany(u => u.Historiales)
            .HasForeignKey(h => h.IdUsuario)
            .IsRequired();

        var accionGuid = Guid.Parse("12345678-1234-1234-1234-1234567890ab");
        var comediaGuid = Guid.Parse("23456789-2345-2345-2345-2345678901bc");
        var dramaGuid = Guid.Parse("34567890-3456-3456-3456-3456789012cd");
        var romanceGuid = Guid.Parse("45678901-4567-4567-4567-4567890123de");
        var terrorGuid = Guid.Parse("34567890-3456-3456-3456-3456789012ab");

        modelBuilder.Entity<Genero>().HasData(
            new Genero { IdGenero = accionGuid, NombreGenero = Genero.GeneroPelicula.Accion },
            new Genero { IdGenero = comediaGuid, NombreGenero = Genero.GeneroPelicula.Comedia },
            new Genero { IdGenero = dramaGuid, NombreGenero = Genero.GeneroPelicula.Drama },
            new Genero { IdGenero = romanceGuid, NombreGenero = Genero.GeneroPelicula.Romance },
            new Genero { IdGenero = terrorGuid, NombreGenero = Genero.GeneroPelicula.Terror}
        );

        // Datos de Usuarios
        var usuario1Guid = Guid.Parse("56789012-5678-5678-5678-5678901234ef");
        var usuario2Guid = Guid.Parse("67890123-6789-6789-6789-6789012345f0");

        modelBuilder.Entity<Usuario>().HasData(
            new Usuario
            {
                IdUsuario = usuario1Guid, NombreUsuario = "ramiro.zein",
                ClaveUsuario = BCrypt.Net.BCrypt.HashPassword("1234"),
                EstatusUsuario = Usuario.Estatus.Activo
            },
            new Usuario
            {
                IdUsuario = usuario2Guid, NombreUsuario = "maria.lopez",
                ClaveUsuario = BCrypt.Net.BCrypt.HashPassword("nel"),
                EstatusUsuario = Usuario.Estatus.Inactivo
            }
        );

        // Datos de Películas
        var pelicula1Guid = Guid.Parse("78901234-7890-7890-7890-7890123456a1");
        var pelicula2Guid = Guid.Parse("89012345-8901-8901-8901-8901234567b2");
        var pelicula3Guid = Guid.Parse("90123456-9012-9012-9012-9012345678c3");

        modelBuilder.Entity<Pelicula>().HasData(
            new Pelicula
            {
                IdPelicula = pelicula1Guid,
                TituloPelicula = "Accion Épica",
                DuracionPelicula = new TimeOnly(2, 30),
                DescripcionPelicula = "Una emocionante aventura de acción.",
                ClasificacionPelicula = 5,
                IdGenero = accionGuid
            },
            new Pelicula
            {
                IdPelicula = pelicula2Guid,
                TituloPelicula = "Comedia Ligera",
                DuracionPelicula = new TimeOnly(1, 45),
                DescripcionPelicula = "Una comedia divertida para toda la familia.",
                ClasificacionPelicula = 3,
                IdGenero = comediaGuid
            },
            new Pelicula
            {
                IdPelicula = pelicula3Guid,
                TituloPelicula = "Drama Intenso",
                DuracionPelicula = new TimeOnly(2, 0),
                DescripcionPelicula = "Un drama que te dejará sin aliento.",
                ClasificacionPelicula = 4,
                IdGenero = dramaGuid
            }
        );

        // Relación Película-Género
        modelBuilder.Entity<PeliculaGenero>().HasData(
            new PeliculaGenero { IdPelicula = pelicula1Guid, IdGenero = accionGuid },
            new PeliculaGenero { IdPelicula = pelicula2Guid, IdGenero = comediaGuid },
            new PeliculaGenero { IdPelicula = pelicula3Guid, IdGenero = dramaGuid },
            new PeliculaGenero
                { IdPelicula = pelicula1Guid, IdGenero = comediaGuid } // Película 1 también clasificada como Comedia
        );

        // Datos de Historial
        modelBuilder.Entity<Historial>().HasData(
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
            }
        );

        base.OnModelCreating(modelBuilder);
    }
}