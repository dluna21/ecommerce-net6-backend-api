using CB.Entidades;
using api_online_shop.Service.Productos.Modelos;

using MediatR;
using Pro.Data.ICore;
using LinqToDB;

namespace api_online_shop.Service.Pruebas.Querys
{
    public class PruebaQuery: IRequest<IList<testModel>>
    {
        public string nombre { get; set; }
    }

    public class PruebaQueryHandler : IRequestHandler<PruebaQuery, IList<testModel>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IContext _context;
        public PruebaQueryHandler(
            IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._context = unitOfWork.Context;
        }
        public async Task<IList<testModel>> Handle(PruebaQuery request, CancellationToken cancellationToken)
        {
            var query = from p in _context.Query<testModel>()
                        select p;

            return await query.ToListAsync();
             
        }
    }
}
