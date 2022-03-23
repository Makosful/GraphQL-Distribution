using static Gateway.WellKnownSchemaNames;

namespace Gateway;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddHttpClient(Persons, x => x.BaseAddress = new Uri("http://localhost:5001/graphql"));
        services.AddHttpClient(Addresses, x => x.BaseAddress = new Uri("http://localhost:5002/graphql"));

        services.AddGraphQLServer()
            .AddRemoteSchema(Persons)
            .AddRemoteSchema(Addresses);
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

        app.UseRouting();
        app.UseEndpoints(x => { x.MapGraphQL(); });
    }
}