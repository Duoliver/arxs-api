using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TeamMap : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.Property(t => t.Id)
                .HasColumnName("id");
            
            builder.Property(t => t.Name)
                .HasColumnName("name");
            
            builder.Property(t => t.CountryId)
                .HasColumnName("country_id");

            builder.Property(t => t.PreviousTeamId)
                .HasColumnName("previous_team_id");

            builder.HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}