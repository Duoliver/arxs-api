using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TeamChampionshipSeasonDriverMap : IEntityTypeConfiguration<TeamChampionshipSeasonDriver>
    {
        public void Configure(EntityTypeBuilder<TeamChampionshipSeasonDriver> builder)
        {
            builder.Property(t => t.Id)
                .HasColumnName("id");
            
            builder.Property(t => t.DriverId)
                .HasColumnName("driver_id");
            
            builder.Property(t => t.EntryId)
                .HasColumnName("entry_id");
            
            builder.Property(t => t.CountryId)
                .HasColumnName("country_id");
        }
    }
}