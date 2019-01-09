using System.Linq;
using Moot.Business.Entities;
using Moot.Business.Interfaces;
using Moot.DAL.UnitOfWork;

namespace Moot.DAL.Repositories
{
    public class UserRepository:Repository<User>,IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override IQueryable<User> GetObjectSet()
        {
            throw new System.NotImplementedException();
        }
    }
}
