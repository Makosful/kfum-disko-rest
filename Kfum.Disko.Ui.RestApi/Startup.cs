using Kfum.Disko.Core;
using Kfum.Disko.Infrastructure;
using Kfum.Disko.Infrastructure.Database;
using Kfum.Disko.Ui.RestApi.GraphQL;

namespace Kfum.Disko.Ui.RestApi;

public class Startup
{
    private readonly string _connectionString;

    public Startup(IConfiguration configuration)
    {
        _connectionString = $"Server={configuration["DB_ADDR"]};" +
                            $"Port={configuration["DB_PORT"]};" +
                            $"Database={configuration["DB_NAME"]};" +
                            $"Uid={configuration["DB_USER"]};" +
                            $"Pwd={configuration["DB_PASS"]};" +
                            "SslMode=Preferred;";
    }

    public void ConfigureServices(IServiceCollection services)
    {
        NHibernateSessionManager.ConnectionString = _connectionString;

        services.AddCoreDependencies();
        services.AddInfrastructureDependencies();

        services.AddControllers();
        services.AddGraphQLServer()
            .AddQueryType<Query>()
            .AddMutationType<Mutation>()
            // .AddSubscriptionType<Subscription>()
            .AddFiltering()
            .AddSorting()
            .AddInMemorySubscriptions(); // Microsoft.DependencyInjection
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
            using var session = NHibernateSessionManager.GetCurrentSession();
            Seed.SeedDatabase(session);
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapGraphQL();
        });
    }
}