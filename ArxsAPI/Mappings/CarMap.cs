using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");
            
            builder.Property(c => c.Name)
                .HasColumnName("name");
            
            builder.Property(c => c.Year)
                .HasColumnName("year");
            
            builder.Property(c => c.ManufacturerId)
                .HasColumnName("manufacturer_id");
        }
    }
}