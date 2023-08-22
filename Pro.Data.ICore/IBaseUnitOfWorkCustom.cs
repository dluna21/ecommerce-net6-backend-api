using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro.Data.ICore
{
    public interface IBaseUnitOfWorkCustom
    {
        IContextCustom Context { get; }

        Task<T> SqlQuery<T>(string sql, params object[] parameters) where T : class;
    }
}
