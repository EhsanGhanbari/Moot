using System.Collections;
using System.Threading;

namespace Moot.DAL.ContextStorage
{
    public class ThreadDbContextStorageContainer : IDbContextStorageContainer
    {
        private static readonly Hashtable CvDataContexts = new Hashtable();

        public MootDbContext GetDataContext()
        {
            MootDbContext cvDataContext = null;

            if (CvDataContexts.Contains(GetThreadName()))
                cvDataContext = (MootDbContext)CvDataContexts[GetThreadName()];

            return cvDataContext;
        }

        public void Store(MootDbContext libraryDataContext)
        {
            if (CvDataContexts.Contains(GetThreadName()))
                CvDataContexts[GetThreadName()] = libraryDataContext;
            else
                CvDataContexts.Add(GetThreadName(), libraryDataContext);
        }

        private static string GetThreadName()
        {
            return Thread.CurrentThread.Name;
        }
    }
}
