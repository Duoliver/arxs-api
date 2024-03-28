using ArxsAPI.Data;
using ArxsAPI.Models;
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
        builder.Services.AddScoped<DriverRepository>();
        builder.Services.AddScoped<DriverService>();
        builder.Services.AddScoped<ManufacturerRepository>();
        builder.Services.AddScoped<ManufacturerService>();
        builder.Services.AddScoped<CarRepository>();
        builder.Services.AddScoped<CarService>();
        builder.Services.AddScoped<TrackRepository>();
        builder.Services.AddScoped<TrackService>();
        builder.Services.AddScoped<TrackConfigurationRepository>();
        builder.Services.AddScoped<TrackConfigurationService>();
        builder.Services.AddScoped<ScoreRepository>();
        builder.Services.AddScoped<ScoreService>();
        builder.Services.AddScoped<ScoreSystemRepository>();
        builder.Services.AddScoped<ScoreSystemService>();
        builder.Services.AddScoped<SeasonRepository>();
        builder.Services.AddScoped<SeasonService>();
        builder.Services.AddScoped<ChampionshipRepository>();
        builder.Services.AddScoped<ChampionshipService>();
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
