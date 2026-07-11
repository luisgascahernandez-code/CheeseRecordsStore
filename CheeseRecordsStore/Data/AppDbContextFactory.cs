using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CheeseRecordsStore.Data;

public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        // Esta es la misma cadena de conexión de tu appsettings.json
        optionsBuilder.UseNpgsql("Host=localhost;Database=CheeseRecordsDB;Username=postgres;Password=admin123");

        return new AppDbContext(optionsBuilder.Options);
    }
}