using System.Collections.Generic;
using System.Linq;
using Moot.Business;
using Moot.DAL.ContextStorage;
using Moot.DAL.UnitOfWork;

namespace Moot.DAL
{
    public abstract class Repository<T> : IUnitOfWorkRepository where T : IAggregateRoot
    {
        private readonly IUnitOfWork _unitOfWork;

        protected Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public abstract IQueryable<T> GetObjectSet();


        public IEnumerable<T> GetAll()
        {
            return GetObjectSet().ToList<T>();
        }

        public T Get(params object[] keyValues)
        {
            throw new System.NotImplementedException();
        }

        public void Add(T entity)
        {
            _unitOfWork.RegisterNew(entity, this);
        }

        public void Delete(T entity)
        {
            _unitOfWork.RegisterRemoved(entity,this);
        }

        public void Update(T entity)
        {
            _unitOfWork.RegisterAmended(entity,this);
        }


        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public void PersistCreationOf(IAggregateRoot entity)
        {
            DbContextFactory.GetDbContext().SaveChanges(); // in doubt
        }

        public void PersistUpdateOf(IAggregateRoot entity)
        {
            // EF tracks changes
        }

        public void PersistDeletionOf(IAggregateRoot entity)
        {
            DbContextFactory.GetDbContext().SaveChanges(); // in doubt
        }
    }
}
