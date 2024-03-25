using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class ChampionshipSeasonMap : IEntityTypeConfiguration<ChampionshipSeason>
    {
        public void Configure(EntityTypeBuilder<ChampionshipSeason> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");
            
            builder.Property(c => c.SeasonId)
                .HasColumnName("season_id");
            
            builder.Property(c => c.ChampionshipId)
                .HasColumnName("championship_id");
        }
    }
}