using ArxsAPI.Data;
using ArxsAPI.Repositories;
using ArxsAPI.Services;
using Microsoft.OpenApi.Models;

namespace ArxsAPI;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddArxsDbService(builder.Configuration);
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "ARXSDb", Version = "v1" });
        });
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
        builder.Services.AddScoped<ChampionshipSeasonRepository>();
        builder.Services.AddScoped<ChampionshipSeasonService>();
        builder.Services
            .AddControllers(options => {
                var jsonInputFormatter = options.InputFormatters
                    .OfType<Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter>()
                    .Single();
                jsonInputFormatter.SupportedMediaTypes.Add("application/csp-report");
            });

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI(opt =>
        {
            opt.SwaggerEndpoint("/swagger/v1/swagger.json", "ARXSDb V1");
        });

        app.UsePathBase("/api");
        app.UseRouting();
        app.MapControllers();
        app.Run();
    }
}
