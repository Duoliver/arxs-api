using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace ArxsAPI.Data
{
    public static class ArxsDbService
    {
        public static void AddArxsDbService(this IServiceCollection services, IConfiguration configuration)
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(configuration.GetConnectionString("ArxsDatabase"));
            var dataSource = dataSourceBuilder.Build();

            services.AddDbContext<ArxsDbContext>(options =>
            {
                options.UseNpgsql(dataSource);
            });
            services.AddSingleton(configuration);
        }
    }
}