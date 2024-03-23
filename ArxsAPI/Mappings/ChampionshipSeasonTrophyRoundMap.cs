using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class ChampionshipSeasonTrophyRoundMap : IEntityTypeConfiguration<ChampionshipSeasonTrophyRound>
    {
        public void Configure(EntityTypeBuilder<ChampionshipSeasonTrophyRound> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");

            builder.Property(c => c.Order)
                .HasColumnName("order");

            builder.Property(c => c.TrophyId)
                .HasColumnName("trophy_id");
            
            builder.Property(c => c.RoundId)
                .HasColumnName("round_id");
        }
    }
}