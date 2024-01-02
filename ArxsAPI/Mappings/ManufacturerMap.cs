using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class ManufacturerMap : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> builder)
        {
            builder.Property(m => m.Id)
                .HasColumnName("id");
            
            builder.Property(m => m.Name)
                .HasColumnName("name");
            
            builder.Property(m => m.CountryId)
                .HasColumnName("country_id");

            builder.HasIndex(m => m.Name)
                .IsUnique();
        }
    }
}