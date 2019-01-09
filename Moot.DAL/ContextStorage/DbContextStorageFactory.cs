using System.Web;

namespace Moot.DAL.ContextStorage
{
    public class DbContextStorageFactory
    {
        public static IDbContextStorageContainer DataContectStorageContainer;

        public static IDbContextStorageContainer CreateStorageContainer()
        {
            if (DataContectStorageContainer == null)
            {
                if (HttpContext.Current == null)
                    DataContectStorageContainer = new ThreadDbContextStorageContainer();
                else
                    DataContectStorageContainer = new HttpDbContextStorageContainer();
            }

            return DataContectStorageContainer;
        }
    }
}
