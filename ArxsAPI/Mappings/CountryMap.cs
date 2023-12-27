using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class CountryMap : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");
            
            builder.Property(c => c.Name)
                .HasColumnName("name");
            
            builder.Property(c => c.Iso3)
                .HasColumnName("iso_3");
            
            builder.Property(c => c.Adjective)
                .HasColumnName("adjective");

            builder.HasIndex(c => c.Name)
                .IsUnique();
            
            builder.HasIndex(c => c.Iso3)
                .IsUnique();
        }
    }
}