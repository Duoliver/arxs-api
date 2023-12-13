using ArxsAPI.Data;

namespace ArxsAPI;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddArxsDbService(builder.Configuration);

        var app = builder.Build();
        app.UsePathBase("/api");
        app.UseRouting();
        // app.MapControllers();
        app.Run();
    }
}
