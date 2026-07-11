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

    public DbSet<Beat> Beats { get; set; }
}