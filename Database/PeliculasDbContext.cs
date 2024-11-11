using API_PELICULAS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.DatabaseContext;

public class PeliculasDbContext : DbContext
{
    public PeliculasDbContext(DbContextOptions<PeliculasDbContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Historial> Historiales { get; set; }
    public DbSet<Pelicula> Peliculas { get; set; }
    public DbSet<Genero> Generos { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Usuario>();
        
        modelBuilder.Entity<Historial>();
        
        modelBuilder.Entity<Pelicula>();
        
        modelBuilder.Entity<Genero>();
        
        base.OnModelCreating(modelBuilder);
    }
}