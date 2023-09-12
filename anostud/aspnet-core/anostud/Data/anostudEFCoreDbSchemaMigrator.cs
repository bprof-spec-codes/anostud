using Microsoft.EntityFrameworkCore;
using Volo.Abp.DependencyInjection;

namespace anostud.Data;

public class anostudEFCoreDbSchemaMigrator : ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public anostudEFCoreDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the anostudDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<anostudDbContext>()
            .Database
            .MigrateAsync();
    }
}
