using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.DatabaseContext;

public class PeliculasDbContext : DbContext
{
    public PeliculasDbContext(DbContextOptions<PeliculasDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
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
            .HasOne(h => h.Usuario)
            .WithMany(u => u.Historiales)
            .HasForeignKey(h => h.IdUsuario);

        var usuarios = new List<Usuario>
        {
            new Usuario
            {
                IdUsuario = Guid.Parse("0a1b2c3d-4e5f-6a7b-8c9d-0e1f2a3b4c5d"), NombreUsuario = "usuario1",
                ClaveUsuario = "clave1", EstatusUsuario = Usuario.Estatus.Activo
            },
            new Usuario
            {
                IdUsuario = Guid.Parse("1b2c3d4e-5f6a-7b8c-9d0e-1f2a3b4c5d6e"), NombreUsuario = "usuario2",
                ClaveUsuario = "clave2", EstatusUsuario = Usuario.Estatus.Activo
            },
            new Usuario
            {
                IdUsuario = Guid.Parse("2c3d4e5f-6a7b-8c9d-0e1f-2a3b4c5d6e7f"), NombreUsuario = "usuario3",
                ClaveUsuario = "clave3", EstatusUsuario = Usuario.Estatus.Inactivo
            }
        };

        var generos = new List<Genero>
        {
            new Genero { IdGenero = Guid.Parse("3d4e5f6a-7b8c-9d0e-1f2a-3b4c5d6e7f8a"), NombreGenero = Genero.GeneroPelicula.Accion },
            new Genero { IdGenero = Guid.Parse("4e5f6a7b-8c9d-0e1f-2a3b-4c5d6e7f8a9b"), NombreGenero = Genero.GeneroPelicula.Drama },
            new Genero { IdGenero = Guid.Parse("5f6a7b8c-9d0e-1f2a-3b4c-5d6e7f8a9b0c"), NombreGenero = Genero.GeneroPelicula.Romance }
        };

        var peliculas = new List<Pelicula>
        {
            new Pelicula
            {
                IdPelicula = Guid.Parse("6a7b8c9d-0e1f-2a3b-4c5d-6e7f8a9b0c1d"), TituloPelicula = "Película 1",
                DuracionPelicula = TimeOnly.Parse("01:30"), DescripcionPelicula = "Una película de acción.",
                ClasificacionPelicula = 5, IdGenero = generos[0].IdGenero
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("7b8c9d0e-1f2a-3b4c-5d6e-7f8a9b0c1d2e"), TituloPelicula = "Película 2",
                DuracionPelicula = TimeOnly.Parse("02:00"), DescripcionPelicula = "Una comedia romántica.",
                ClasificacionPelicula = 4, IdGenero = generos[1].IdGenero
            },
            new Pelicula
            {
                IdPelicula = Guid.Parse("8c9d0e1f-2a3b-4c5d-6e7f-8a9b0c1d2e3f"), TituloPelicula = "Película 3",
                DuracionPelicula = TimeOnly.Parse("01:45"), DescripcionPelicula = "Un drama familiar.",
                ClasificacionPelicula = 3, IdGenero = generos[2].IdGenero
            }
        };

        var historiales = new List<Historial>
        {
            new Historial
            {
                IdHistorial = Guid.Parse("9d0e1f2a-3b4c-5d6e-7f8a-9b0c1d2e3f4a"), IdPelicula = peliculas[0].IdPelicula,
                IdUsuario = usuarios[0].IdUsuario, FechaVista = DateOnly.Parse("2024-01-01")
            },
            new Historial
            {
                IdHistorial = Guid.Parse("0e1f2a3b-4c5d-6e7f-8a9b-0c1d2e3f4a5b"), IdPelicula = peliculas[1].IdPelicula,
                IdUsuario = usuarios[1].IdUsuario, FechaVista = DateOnly.Parse("2024-02-01")
            },
            new Historial
            {
                IdHistorial = Guid.Parse("1f2a3b4c-5d6e-7f8a-9b0c-1d2e3f4a5b6c"), IdPelicula = peliculas[2].IdPelicula,
                IdUsuario = usuarios[2].IdUsuario, FechaVista = DateOnly.Parse("2024-03-01")
            }
        };

        var peliculaGeneros = new List<PeliculaGenero>
        {
            new PeliculaGenero { IdPelicula = peliculas[0].IdPelicula, IdGenero = generos[0].IdGenero },
            new PeliculaGenero { IdPelicula = peliculas[1].IdPelicula, IdGenero = generos[1].IdGenero },
            new PeliculaGenero { IdPelicula = peliculas[2].IdPelicula, IdGenero = generos[2].IdGenero }
        };

        base.OnModelCreating(modelBuilder);
    }
}