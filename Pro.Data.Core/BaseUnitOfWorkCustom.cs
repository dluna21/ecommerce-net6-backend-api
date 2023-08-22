using Pro.Data.ICore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Data.Core
{
    public class BaseUnitOfWorkCustom :    IDisposable
    {
        private IDbContext _ctx;
        public void Dispose()
        {
            _ctx.Dispose();
        } 
        //public IQueryable<T> Query<T>(bool asNoTracking = true) where T : class
        //{

        //}
    }
}
