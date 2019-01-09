using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moot.DAL.ContextStorage
{
    public class DbContextFactory
    {
        public static MootDbContext GetDbContext()
        {
            IDbContextStorageContainer dataContextStorageContainer = DbContextStorageFactory.CreateStorageContainer();

            var libraryDataContext = dataContextStorageContainer.GetDataContext();
            if (libraryDataContext == null)
            {
                libraryDataContext = new MootDbContext();
                dataContextStorageContainer.Store(libraryDataContext);
            }

            return libraryDataContext;
        }
    }
}
