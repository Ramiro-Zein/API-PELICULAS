using Microsoft.EntityFrameworkCore;

namespace API_PELICULAS.DatabaseContext;

public class PeliculasDbContext : DbContext
{
    public PeliculasDbContext(DbContextOptions<PeliculasDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}