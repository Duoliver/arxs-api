using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class ChampionshipSeasonRoundMap : IEntityTypeConfiguration<ChampionshipSeasonRound>
    {
        public void Configure(EntityTypeBuilder<ChampionshipSeasonRound> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");
            
            builder.Property(c => c.Name)
                .HasColumnName("name");
            
            builder.Property(c => c.ChampionshipSeasonId)
                .HasColumnName("championship_season_id");
            
            builder.Property(c => c.TrackConfigurationId)
                .HasColumnName("track_configuration_id");
        }
    }
}