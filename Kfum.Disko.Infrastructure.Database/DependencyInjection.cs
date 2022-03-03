using Kfum.Disko.Core.DomainServices;
using Kfum.Disko.Infrastructure.Database.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Kfum.Disko.Infrastructure.Database;

public static class DependencyInjection
{
    public static void AddDatabaseDependencies(this IServiceCollection services)
    {
        services.AddScoped<IMemberRepository, MemberRepository>();
    }
}