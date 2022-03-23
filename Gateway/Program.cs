namespace Gateway;

public static class Program
{
    public static void Main(string[] args)
    {
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(x => { x.UseStartup<Startup>(); })
            .Build().Run();
    }
}