using System.Web;

namespace Moot.DAL.ContextStorage
{
    public class HttpDbContextStorageContainer : IDbContextStorageContainer
    {
        private const string DataContextKey = "DataContext";

        public MootDbContext GetDataContext()
        {
            MootDbContext objectContext = null;
            if (HttpContext.Current.Items.Contains(DataContextKey))
                objectContext = (MootDbContext)HttpContext.Current.Items[DataContextKey];

            return objectContext;
        }

        public void Store(MootDbContext libraryDataContext)
        {
            if (HttpContext.Current.Items.Contains(DataContextKey))
                HttpContext.Current.Items[DataContextKey] = libraryDataContext;
            else
                HttpContext.Current.Items.Add(DataContextKey, libraryDataContext);
        }

    }
}
