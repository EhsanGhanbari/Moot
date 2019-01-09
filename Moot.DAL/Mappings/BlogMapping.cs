using System.Data.Entity.ModelConfiguration;
using Moot.Business.Entities;

namespace Moot.DAL.Mappings
{
    public class BlogMapping:EntityTypeConfiguration<Blog>
    {
        public BlogMapping()
        {
            HasKey(b => b.Id);
            Property(b => b.Title).IsRequired().HasMaxLength(100);
            Property(b => b.Post).IsRequired();
            Property(b => b.CreationTime).IsRequired();
            Property(b => b.Summary).IsOptional();
            Property(b => b.Image).IsOptional();
        }
    }
}
