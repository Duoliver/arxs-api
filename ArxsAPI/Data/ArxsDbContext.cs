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
        public virtual DbSet<Driver> Drivers { get; set; }

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

            modelBuilder.Entity<Driver>()
                .ToTable("driver")
                .HasKey(d => d.Id);
            modelBuilder.Entity<Driver>()
                .HasOne(d => d.CountryOfOrigin)
                .WithMany(c => c.NativeDrivers)
                .HasForeignKey(d => d.CountryOfOriginId);
            modelBuilder.Entity<Driver>()
                .HasOne(d => d.Nationality)
                .WithMany(c => c.NationalDrivers)
                .HasForeignKey(d => d.NationalityId);
            modelBuilder.ApplyConfiguration(new DriverMap());
        }
    }
}