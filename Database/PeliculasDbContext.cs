using API_PELICULAS.Database.Configurations;
using API_PELICULAS.Database.Data;

using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.Database;

public class PeliculasDbContext : DbContext
{
    public PeliculasDbContext(DbContextOptions<PeliculasDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Historial> Historiales { get; set; }
    public DbSet<Pelicula> Peliculas { get; set; }
    public DbSet<Genero> Generos { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PeliculaGeneroConfiguration());
        modelBuilder.ApplyConfiguration(new HistorialConfiguration());
        
        // Datos
        modelBuilder.ApplyConfiguration(new GeneroData());
        modelBuilder.ApplyConfiguration(new UsuarioData());
        modelBuilder.ApplyConfiguration(new PeliculaData());
        modelBuilder.ApplyConfiguration(new HistorialData());
        modelBuilder.ApplyConfiguration(new PeliculaGeneroData());
        
        base.OnModelCreating(modelBuilder);
    }
}