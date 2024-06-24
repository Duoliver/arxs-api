using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class ChampionshipSeasonTrophyMap : IEntityTypeConfiguration<ChampionshipSeasonTrophy>
    {
        public void Configure(EntityTypeBuilder<ChampionshipSeasonTrophy> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");

            builder.Property(c => c.Name)
                .HasColumnName("name");

            builder.Property(c => c.TrophyId)
                .HasColumnName("trophy_id");

            builder.Property(c => c.ScoreSystemId)
                .HasColumnName("score_system_id");
            
            builder.Property(c => c.ChampionshipSeasonId)
                .HasColumnName("championship_season_id");
        }
    }
}
