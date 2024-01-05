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
        builder.Services.AddScoped<DriverService>();
        builder.Services.AddScoped<DriverRepository>();
        builder.Services.AddScoped<ManufacturerService>();
        builder.Services.AddScoped<ManufacturerRepository>();
        builder.Services.AddScoped<CarService>();
        builder.Services.AddScoped<CarRepository>();
        builder.Services.AddScoped<TrackService>();
        builder.Services.AddScoped<TrackRepository>();
        builder.Services.AddScoped<TrackConfigurationService>();
        builder.Services.AddScoped<TrackConfigurationRepository>();
        builder.Services
            .AddControllers(options => {
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
