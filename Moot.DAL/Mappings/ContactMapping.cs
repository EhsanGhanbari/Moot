using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Moot.Business.Entities;

namespace Moot.DAL.Mappings
{
    public class ContactMapping :EntityTypeConfiguration<Contact>
    {
        public ContactMapping()
        {
            ToTable("Contact");
            HasKey(c => c.Id);
            Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.Name).HasMaxLength(40);
            Property(c => c.Title).IsOptional().HasMaxLength(100);
            Property(c => c.Body).IsRequired();
            Property(c => c.Email).IsRequired().HasMaxLength(80);
            Property(c => c.ContactDate).IsRequired();
            Property(c => c.ReplyBody).IsOptional();

        }
    }
}
