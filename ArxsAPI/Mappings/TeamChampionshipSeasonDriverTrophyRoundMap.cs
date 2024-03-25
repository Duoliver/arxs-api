using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TeamChampionshipSeasonDriverTrophyRoundMap : IEntityTypeConfiguration<TeamChampionshipSeasonDriverTrophyRound>
    {
        public void Configure(EntityTypeBuilder<TeamChampionshipSeasonDriverTrophyRound> builder)
        {
            builder.Property(t => t.Id)
                .HasColumnName("id");
            
            builder.Property(t => t.Position)
                .HasColumnName("position");
            
            builder.Property(t => t.Status)
                .HasColumnName("status");
            
            builder.Property(t => t.DriverEntryId)
                .HasColumnName("driver_entry_id");
            
            builder.Property(t => t.TrophyRoundId)
                .HasColumnName("trophy_round_id");
        }
    }
}