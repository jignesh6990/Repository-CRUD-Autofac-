using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWorld.Data
{
    public class DatabaseFactory : IDisposable, IDatabaseFactory
    {
        private ERDDBContext dataContext;
        public void Dispose()
        {
            if(dataContext!=null)
            {
                dataContext.Dispose();
            }
        }

        public ERDDBContext Get()
        {
            return dataContext ?? (dataContext = new ERDDBContext());
        }
    }
}
