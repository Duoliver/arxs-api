using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class DriverMap : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.Property(d => d.Id)
                .HasColumnName("id");
            
            builder.Property(d => d.Name)
                .HasColumnName("name");
            
            builder.Property(d => d.Surname)
                .HasColumnName("surname");
            
            builder.Property(d => d.DateOfBirth)
                .HasColumnName("date_of_birth");
            
            builder.Property(d => d.CityOfOrigin)
                .HasColumnName("city_of_origin");
            
            builder.Property(d => d.CountryOfOriginId)
                .HasColumnName("country_of_origin_id");
            
            builder.Property(d => d.NationalityId)
                .HasColumnName("nationality_id");
        }
    }
}