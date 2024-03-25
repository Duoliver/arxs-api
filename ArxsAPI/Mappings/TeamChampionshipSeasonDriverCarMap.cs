using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TeamChampionshipSeasonDriverCarMap : IEntityTypeConfiguration<TeamChampionshipSeasonDriverCar>
    {
        public void Configure(EntityTypeBuilder<TeamChampionshipSeasonDriverCar> builder)
        {
            builder.Property(t => t.Id)
                .HasColumnName("id");
            
            builder.Property(t => t.TeamCarId)
                .HasColumnName("team_car_id");
            
            builder.Property(t => t.DriverEntryId)
                .HasColumnName("driver_entry_id");
        }
    }
}