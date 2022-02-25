using Kfum.Disko.Ui.RestApi.GraphQL;

namespace Kfum.Disko.Ui.RestApi;

public class Startup
{
    private readonly IConfiguration Configuration;

    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();

        services.AddGraphQLServer()
            .AddQueryType<Query>()                  // HotChocolate
            .AddFiltering()                         // HotChocolate.Data
            .AddSorting()                           // HotChocolate.Data
            .AddInMemorySubscriptions();            // Microsoft.DependencyInjection
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
            endpoints.MapGraphQL();
        });
    }
}