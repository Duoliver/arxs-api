using ArxsAPI.Data;
using ArxsAPI.Repositories;
using ArxsAPI.Services;

namespace ArxsAPI;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddArxsDbService(builder.Configuration);
        builder.Services.AddScoped<CountryRepository>();
        builder.Services.AddScoped<CountryService>();
        builder.Services.AddControllers(options => {
            var jsonInputFormatter = options.InputFormatters
                .OfType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter>()
                .Single();
            jsonInputFormatter.SupportedMediaTypes.Add("application/csp-report");
        });


        var app = builder.Build();
        app.UsePathBase("/api");
        app.UseRouting();
        app.MapControllers();
        app.Run();
    }
}
