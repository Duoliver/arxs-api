using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TrackMap : IEntityTypeConfiguration<Track>
    {
        public void Configure(EntityTypeBuilder<Track> builder)
        {
            builder.Property(t => t.Id)
                .HasColumnName("id");
            
            builder.Property(t => t.Name)
                .HasColumnName("name");
            
            builder.Property(t => t.City)
                .HasColumnName("city");
            
            builder.HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}