using Kfum.Disko.Core.ApplicationServices;
using Kfum.Disko.Core.ApplicationServices.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Kfum.Disko.Core;

public static class DependencyInjection
{
    public static void AddCoreDependencies(this IServiceCollection services)
    {
        services.AddScoped<IMemberService, MemberService>();
        services.AddScoped<IArrangementService, ArrangementService>();
    }
}