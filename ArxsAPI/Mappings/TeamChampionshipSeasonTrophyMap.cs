using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TeamChampionshipSeasonTrophyMap : IEntityTypeConfiguration<TeamChampionshipSeasonTrophy>
    {
        public void Configure(EntityTypeBuilder<TeamChampionshipSeasonTrophy> builder)
        {
            builder.Property(t => t.Id)
                .HasColumnName("id");
                        
            builder.Property(t => t.EntryId)
                .HasColumnName("entry_id");

            builder.Property(t => t.TrophyId)
                .HasColumnName("trophy_id");
        }
    }
}