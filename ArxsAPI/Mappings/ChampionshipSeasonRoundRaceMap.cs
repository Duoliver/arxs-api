using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class ChampionshipSeasonRoundRaceMap : IEntityTypeConfiguration<ChampionshipSeasonRoundRace>
    {
        public void Configure(EntityTypeBuilder<ChampionshipSeasonRoundRace> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");
            
            builder.Property(c => c.Order)
                .HasColumnName("order");
            
            builder.Property(c => c.Type)
                .HasColumnName("type");
            
            builder.Property(c => c.LapCount)
                .HasColumnName("lap_count");
            
            builder.Property(c => c.RoundId)
                .HasColumnName("round_id");
        }
    }
}