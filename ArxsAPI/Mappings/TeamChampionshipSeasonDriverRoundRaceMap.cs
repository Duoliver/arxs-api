using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TeamChampionshipSeasonDriverRoundRaceMap : IEntityTypeConfiguration<TeamChampionshipSeasonDriverRoundRace>
    {
        public void Configure(EntityTypeBuilder<TeamChampionshipSeasonDriverRoundRace> builder)
        {
            builder.Property(t => t.Id)
                .HasColumnName("id");
                        
            builder.Property(t => t.Position)
                .HasColumnName("position");

            builder.Property(t => t.Status)
                .HasColumnName("status");
            
            builder.Property(t => t.DriverEntryId)
                .HasColumnName("driver_entry_id");
            
            builder.Property(t => t.RoundRaceId)
                .HasColumnName("round_race_id");
        }
    }
}