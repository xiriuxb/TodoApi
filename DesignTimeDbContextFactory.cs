using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TodoApi.Entities;

namespace TodoApp;
public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
{
    public DatabaseContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = JsonConfigurationExtensions.AddJsonFile(
                new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()),
                "appsettings.json"
            )
            .Build();

        var connectionString = configuration.GetConnectionString("DefaultConnection");

        var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        return new DatabaseContext(optionsBuilder.Options);
    }
}
