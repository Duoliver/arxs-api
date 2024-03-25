using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class ScoreSystemMap : IEntityTypeConfiguration<ScoreSystem>
    {
        public void Configure(EntityTypeBuilder<ScoreSystem> builder)
        {
            builder.Property(ss => ss.Id)
                .HasColumnName("id");
            
            builder.Property(ss => ss.Alias)
                .HasColumnName("alias");
        }
    }
}