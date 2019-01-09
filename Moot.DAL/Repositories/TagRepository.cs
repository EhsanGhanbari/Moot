using System;
using System.Linq;
using Moot.Business.Entities;
using Moot.Business.Interfaces;
using Moot.DAL.UnitOfWork;

namespace Moot.DAL.Repositories
{
    public class TagRepository:Repository<Tag>,ITagRepository 
    {
        public TagRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public override IQueryable<Tag> GetObjectSet()
        {
            throw new NotImplementedException();
        }
    }
}
