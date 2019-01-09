using System.Data.Entity;
using Moot.Business.Entities;
using Moot.DAL.Mappings;

namespace Moot.DAL.ContextStorage
{
    public class MootDbContext :DbContext 
    {
        public MootDbContext()
            : base("name=MootDbContext")
        {
            if (Database.Exists() && !Database.CompatibleWithModel(false))
                Database.Delete();
            if (!Database.Exists()) Database.Create();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new ContactMapping());
            modelBuilder.Configurations.Add(new QuestionMapping());
            modelBuilder.Configurations.Add(new TagMapping());
            modelBuilder.Configurations.Add(new UserMapping());
        }

        public DbSet<Contact> Contacts { get; set; } 
        public DbSet<Question> Questions { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
