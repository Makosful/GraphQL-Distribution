using AddressService.GraphQL;
using StackExchange.Redis;

namespace AddressService;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton(ConnectionMultiplexer.Connect("localhost:6379"));
        services.AddGraphQLServer()
            .AddQueryType<Query>()
            .AddFiltering()
            .AddSorting()
            .InitializeOnStartup()
            .PublishSchemaDefinition(x => x
                .SetName("addresses")
                .PublishToRedis("Demo", provider => provider
                    .GetRequiredService<ConnectionMultiplexer>()));
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

        app.UseRouting();
        app.UseEndpoints(x => { x.MapGraphQL(); });
    }
}