using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TrackConfigurationMap : IEntityTypeConfiguration<TrackConfiguration>
    {
        public void Configure(EntityTypeBuilder<TrackConfiguration> builder)
        {
            builder.Property(t => t.Id)
                .HasColumnName("id");
            
            builder.Property(t => t.Name)
                .HasColumnName("name");
            
            builder.Property(t => t.Year)
                .HasColumnName("year");
            
            builder.Property(t => t.TrackId)
                .HasColumnName("track_id");
        }
    }
}