using ArxsAPI.Enums;
using ArxsAPI.Mappings;
using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ArxsAPI.Data
{
    public class ArxsDbContext : DbContext
    {
        public ArxsDbContext(DbContextOptions<ArxsDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<RaceType>();
            modelBuilder.HasPostgresEnum<RoundRaceDriverStatus>();
            modelBuilder.HasPostgresEnum<TrophyRoundDriverStatus>();

            modelBuilder.Entity<Country>()
                .ToTable("country")
                .HasKey(c => c.Id);
            modelBuilder.ApplyConfiguration(new CountryMap());
        }
    }
}