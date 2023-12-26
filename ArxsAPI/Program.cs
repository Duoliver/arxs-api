using System.Text.Json.Serialization;
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
        builder.Services.AddScoped<CsvService>();
        builder.Services.AddScoped<TeamRepository>();
        builder.Services.AddScoped<TeamService>();
        builder.Services
            .AddControllers(options => {
                var jsonInputFormatter = options.InputFormatters
                    .OfType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter>()
                    .Single();
                jsonInputFormatter.SupportedMediaTypes.Add("application/csp-report");
            });
            // .AddJsonOptions(o => o.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);

        var app = builder.Build();
        app.UsePathBase("/api");
        app.UseRouting();
        app.MapControllers();
        app.Run();
    }
}
