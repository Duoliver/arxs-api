using ArxsAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArxsAPI.Mappings
{
    public class ChampionshipMap : IEntityTypeConfiguration<Championship>
    {
        public void Configure(EntityTypeBuilder<Championship> builder)
        {
            builder.Property(c => c.Id)
                .HasColumnName("id");
            
            builder.Property(c => c.Name)
                .HasColumnName("name");
            
            builder.Property(c => c.Alias)
                .HasColumnName("alias");
            
            builder.Property(c => c.PredecessorId)
                .HasColumnName("predecessor_id");
        }
    }
}