using CheeseRecordsStore.Models;
using Microsoft.EntityFrameworkCore;

namespace CheeseRecordsStore.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            // Fallback de emergencia por si EF no encuentra el Factory
            optionsBuilder.UseNpgsql("Host=localhost;Database=CheeseRecordsDB;Username=postgres;Password=admin123");
        }
    }

    // AQUÍ ESTÁN LAS 5 TABLAS RELACIONADAS
    public DbSet<Beat> Beats { get; set; }
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Genero> Generos { get; set; }
    public DbSet<Licencia> Licencias { get; set; }
    public DbSet<Album> Albumes { get; set; }
}