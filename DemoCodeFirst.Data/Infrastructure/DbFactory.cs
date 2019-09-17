using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoCodeFirst.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        DemoCodeFirstDbContext dbContext;
        public DemoCodeFirstDbContext Init()
        {
            return dbContext ?? (dbContext = new DemoCodeFirstDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}
