using Kfum.Disko.Infrastructure.Database;
using Microsoft.Extensions.DependencyInjection;

namespace Kfum.Disko.Infrastructure;

public static class DependencyInjection
{
    public static void AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddDatabaseDependencies();
    }
}