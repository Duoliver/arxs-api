using ArxsAPI.Enums;
using ArxsAPI.Mappings;
using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ArxsAPI.Data
{
    public class ArxsDbContext(DbContextOptions<ArxsDbContext> options) : DbContext(options)
    {
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<RaceType>();
            modelBuilder.HasPostgresEnum<RoundRaceDriverStatus>();
            modelBuilder.HasPostgresEnum<TrophyRoundDriverStatus>();

            modelBuilder.Entity<Country>()
                .ToTable("country")
                .HasKey(c => c.Id);
            modelBuilder.ApplyConfiguration(new CountryMap());

            modelBuilder.Entity<Team>()
                .ToTable("team")
                .HasKey(t => t.Id);
            modelBuilder.Entity<Team>()
                .HasOne(t => t.PreviousTeam)
                .WithOne(pt => pt.NextTeam)
                .HasForeignKey<Team>(t => t.PreviousTeamId);
            modelBuilder.Entity<Team>()
                .HasOne(t => t.Country)
                .WithMany(c => c.Teams)
                .HasForeignKey(t => t.CountryId);
            modelBuilder.ApplyConfiguration(new TeamMap());
        }
    }
}