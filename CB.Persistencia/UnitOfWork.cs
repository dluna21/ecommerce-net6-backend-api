using CB.Core.Aplicacion;
using Pro.Data.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CB.Persistencia
{
    public class UnitOfWork : BaseUnitOfWork, IUnitOfWork
    {
        private readonly IDbContext _ctx;
        public UnitOfWork(IDbContext ctx)
              : base(ctx)
        {
            _ctx = ctx;
        }
    }
}
