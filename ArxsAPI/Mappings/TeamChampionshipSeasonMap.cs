using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TeamChampionshipSeasonMap : IEntityTypeConfiguration<TeamChampionshipSeason>
    {
        public void Configure(EntityTypeBuilder<TeamChampionshipSeason> builder)
        {
            builder.Property(tc => tc.Id)
                .HasColumnName("id");
            
            builder.Property(tc => tc.Name)
                .HasColumnName("name");
            
            builder.Property(tc => tc.Colour)
                .HasColumnName("colour");
            
            builder.Property(tc => tc.ChampionshipSeasonId)
                .HasColumnName("championship_season_id");

            builder.Property(tc => tc.TeamId)
                .HasColumnName("team_id");
            
            builder.Property(tc => tc.CountryId)
                .HasColumnName("country_id");
        }
    }
}