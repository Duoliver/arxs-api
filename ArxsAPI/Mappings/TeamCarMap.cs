using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TeamCarMap : IEntityTypeConfiguration<TeamCar>
    {
        public void Configure(EntityTypeBuilder<TeamCar> builder)
        {
            builder.Property(tc => tc.Id)
                .HasColumnName("id");
            
            builder.Property(tc => tc.Suffix)
                .HasColumnName("suffix");
            
            builder.Property(tc => tc.Year)
                .HasColumnName("year");
            
            builder.Property(tc => tc.CarModelId)
                .HasColumnName("car_model_id");

            builder.Property(tc => tc.TeamId)
                .HasColumnName("team_id");
        }
    }
}