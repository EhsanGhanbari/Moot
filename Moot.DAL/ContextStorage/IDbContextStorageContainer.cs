using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moot.DAL.ContextStorage
{
    public interface IDbContextStorageContainer
    {
        MootDbContext GetDataContext();
        void Store(MootDbContext libraryDataContext);
    }
}
