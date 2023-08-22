using CB.Entidades; 
using MediatR;
using Pro.Data.ICore;
using LinqToDB;

namespace CB.Core.Aplicacion.Service.Pruebas.Querys
{
    public class PruebaQuery: IRequest<IList<testModel>>
    {
        public string nombre { get; set; }
    }

    public class PruebaQueryHandler : IRequestHandler<PruebaQuery, IList<testModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IContext _context;
        //private readonly OnlineShopContext _context;

        public PruebaQueryHandler(
            IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._context = unitOfWork.Context;
        }

        //public PruebaQueryHandler(OnlineShopContext context) {
        //    this.context = context;
        //}

        public async Task<IList<testModel>> Handle(PruebaQuery request, CancellationToken cancellationToken)
        {
            
            var query = from p in _context.Query<testModel>()
                        select p;

            return await query.ToListAsync();
             
        }
    }
}
