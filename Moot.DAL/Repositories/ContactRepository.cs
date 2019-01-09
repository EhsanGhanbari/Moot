using System.Linq;
using Moot.Business.Entities;
using Moot.Business.Interfaces;
using Moot.DAL.ContextStorage;
using Moot.DAL.UnitOfWork;

namespace Moot.DAL.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override IQueryable<Contact> GetObjectSet()
        {
            return DbContextFactory.GetDbContext().Set<Contact>();
        }

        //public Contact FindBy(Contact entity)
        //{
        //    return GetObjectSet().FirstOrDefault(b => b.Id == entity.Id);
        //}
    }
}
