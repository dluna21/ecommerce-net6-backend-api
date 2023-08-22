using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Data.ICore
{
    public interface IContextCustom
    {
        IQueryable<T> Query<T>(bool asNoTracking = true) where T : class;
    }
}
