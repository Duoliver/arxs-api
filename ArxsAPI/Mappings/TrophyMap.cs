using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class TrophyMap : IEntityTypeConfiguration<Trophy>
    {
        public void Configure(EntityTypeBuilder<Trophy> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");

            builder.Property(c => c.Name)
                .HasColumnName("name");
            
            builder.Property(c => c.Type)
                .HasColumnName("type");
        }
    }
}