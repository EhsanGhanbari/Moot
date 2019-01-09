using System;
using System.Collections.Generic;

namespace Moot.Business
{
    public interface IRepository<T> :IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        T Get(params Object[] keyValues);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);

    }
}