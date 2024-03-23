using ArxsAPI.Enums;
using ArxsAPI.Mappings;
using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ArxsAPI.Data
{
    public class ArxsDbContext(DbContextOptions<ArxsDbContext> options) : DbContext(options)
    {
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Season> Seasons { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Car> Cars { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
        public virtual DbSet<Score> Scores { get; set; }
        public virtual DbSet<ScoreSystem> ScoreSystems { get; set; }
        public virtual DbSet<ChampionshipSeason> ChampionshipSeasons { get; set; }
        public virtual DbSet<ChampionshipSeasonRound> ChampionshipSeasonRounds { get; set; }
        public virtual DbSet<ChampionshipSeasonRoundRace> ChampionshipSeasonRoundRaces { get; set; }
        public virtual DbSet<ChampionshipSeasonTrophy> ChampionshipSeasonTrophies { get; set; }
        public virtual DbSet<ChampionshipSeasonTrophyRound> ChampionshipSeasonTrophyRounds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresEnum<RaceType>();
            modelBuilder.HasPostgresEnum<RoundRaceDriverStatus>();
            modelBuilder.HasPostgresEnum<TrophyRoundDriverStatus>();

            modelBuilder.Entity<Country>()
                .ToTable("country")
                .HasKey(c => c.Id);
            modelBuilder.ApplyConfiguration(new CountryMap());

            modelBuilder.Entity<Season>()
                .ToTable("season")
                .HasKey(s => s.Id);
            modelBuilder.ApplyConfiguration(new SeasonMap());

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

            modelBuilder.Entity<Manufacturer>()
                .ToTable("manufacturer")
                .HasKey(m => m.Id);
            modelBuilder.Entity<Manufacturer>()
                .HasOne(m => m.Country)
                .WithMany(c => c.Manufacturers)
                .HasForeignKey(m => m.CountryId);
            modelBuilder.ApplyConfiguration(new ManufacturerMap());

            modelBuilder.Entity<Car>()
                .ToTable("car")
                .HasKey(c => c.Id);
            modelBuilder.Entity<Car>()
                .HasOne(c => c.Manufacturer)
                .WithMany(m => m.Cars)
                .HasForeignKey(c => c.ManufacturerId);
            modelBuilder.ApplyConfiguration(new CarMap());

            modelBuilder.Entity<Track>()
                .ToTable("track")
                .HasKey(c => c.Id);
            modelBuilder.Entity<Track>()
                .HasOne(t => t.Country)
                .WithMany(c => c.Tracks)
                .HasForeignKey(t => t.CountryId);
            modelBuilder.ApplyConfiguration(new TrackMap());

            modelBuilder.Entity<TrackConfiguration>()
                .ToTable("track_configuration")
                .HasKey(tc => tc.Id);
            modelBuilder.Entity<TrackConfiguration>()
                .HasOne(tc => tc.Track)
                .WithMany(t => t.TrackConfigurations)
                .HasForeignKey(tc => tc.TrackId);
            modelBuilder.ApplyConfiguration(new TrackConfigurationMap());

            modelBuilder.Entity<ScoreSystem>()
                .ToTable("score_system")
                .HasKey(ss => ss.Id);
            modelBuilder.ApplyConfiguration(new ScoreSystemMap());

            modelBuilder.Entity<Score>()
                .ToTable("score")
                .HasKey(s => s.Id);
            modelBuilder.Entity<Score>()
                .HasOne(s => s.ScoreSystem)
                .WithMany(ss => ss.Scores)
                .HasForeignKey(s => s.ScoreSystemId);
            modelBuilder.ApplyConfiguration(new ScoreMap());

            modelBuilder.Entity<Championship>()
                .ToTable("championship")
                .HasKey(c => c.Id);
            modelBuilder.Entity<Championship>()
                .HasOne(c1 => c1.Predecessor)
                .WithOne(c2 => c2.Successor)
                .HasForeignKey<Championship>(c1 => c1.PredecessorId);
            modelBuilder.ApplyConfiguration(new ChampionshipMap());

            modelBuilder.Entity<ChampionshipSeason>()
                .ToTable("championship_season")
                .HasKey(cs => cs.Id);                                                                                                                                                                                       
            modelBuilder.Entity<ChampionshipSeason>()
                .HasOne(cs => cs.Championship)
                .WithMany(c => c.ChampionshipSeasons)
                .HasForeignKey(cs => cs.ChampionshipId);
            modelBuilder.ApplyConfiguration(new ChampionshipSeasonMap());      

            modelBuilder.Entity<ChampionshipSeasonRound>()
                .ToTable("championship_season_round")
                .HasKey(csr => csr.Id);
            modelBuilder.Entity<ChampionshipSeasonRound>()
                .HasOne(csr => csr.ChampionshipSeason)
                .WithMany(cs => cs.Rounds)
                .HasForeignKey(csr => csr.ChampionshipSeasonId);
            modelBuilder.Entity<ChampionshipSeasonRound>()
                .HasOne(csr => csr.TrackConfiguration)
                .WithMany(tc => tc.Rounds)
                .HasForeignKey(csr => csr.TrackConfigurationId);
            modelBuilder.ApplyConfiguration(new ChampionshipSeasonRoundMap());

            modelBuilder.Entity<ChampionshipSeasonRoundRace>()
                .ToTable("championship_season_round_race")
                .HasKey(csrr => csrr.Id);
            modelBuilder.Entity<ChampionshipSeasonRoundRace>()
                .HasOne(csrr => csrr.Round)
                .WithMany(csr => csr.RoundRaces)    
                .HasForeignKey(csrr => csrr.RoundId);
            modelBuilder.ApplyConfiguration(new ChampionshipSeasonRoundRaceMap());

            modelBuilder.Entity<ChampionshipSeasonTrophy>()
                .ToTable("championship_season_trophy")
                .HasKey(cst => cst.Id);
            modelBuilder.Entity<ChampionshipSeasonTrophy>()
                .HasOne(cst => cst.ScoreSystem)
                .WithMany(ss => ss.Trophies)
                .HasForeignKey(cst => cst.ScoreSystemId);
            modelBuilder.Entity<ChampionshipSeasonTrophy>()
                .HasOne(cst => cst.ChampionshipSeason)
                .WithMany(cs => cs.Trophies)
                .HasForeignKey(cst => cst.ChampionshipSeasonId);
            modelBuilder.ApplyConfiguration(new ChampionshipSeasonTrophyMap());

            modelBuilder.Entity<ChampionshipSeasonTrophyRound>()
                .ToTable("championship_season_trophy_round")
                .HasKey(cstr => cstr.Id);
            modelBuilder.Entity<ChampionshipSeasonTrophyRound>()
                .HasOne(cstr => cstr.Trophy)
                .WithMany(cst => cst.TrophyRounds)
                .HasForeignKey(cstr => cstr.TrophyId);
            modelBuilder.Entity<ChampionshipSeasonTrophyRound>()
                .HasOne(cstr => cstr.Round)
                .WithMany(csr => csr.RoundTrophies)
                .HasForeignKey(cstr => cstr.RoundId);
            modelBuilder.ApplyConfiguration(new ChampionshipSeasonTrophyRoundMap());
        }
    }
}