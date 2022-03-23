using AddressService.GraphQL;

namespace AddressService;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddGraphQLServer()
            .AddQueryType<Query>()
            .AddFiltering()
            .AddSorting();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

        app.UseRouting();
        app.UseEndpoints(x => { x.MapGraphQL(); });
    }
}