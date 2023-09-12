using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace anostud.Data;

public class anostudDbContextFactory : IDesignTimeDbContextFactory<anostudDbContext>
{
    public anostudDbContext CreateDbContext(string[] args)
    {

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<anostudDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new anostudDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
