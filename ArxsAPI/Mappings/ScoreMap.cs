using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class ScoreMap : IEntityTypeConfiguration<Score>
    {
        public void Configure(EntityTypeBuilder<Score> builder)
        {
            builder.Property(s => s.Id)
                .HasColumnName("id");
            
            builder.Property(s => s.Position)
                .HasColumnName("position");
            
            builder.Property(s => s.ScoreSystemId)
                .HasColumnName("score_system_id");
        }
    }
}