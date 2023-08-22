using CB.Core.Aplicacion.Service.Productos.Modelos;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Pro.Data.ICore;

namespace CB.Core.Aplicacion.Service.Productos.Querys
{
    public class ProductoQuery : IRequest<IList<Producto>>
    {
        public string nombre { get; set; }
    }

    public class ProductoQueryHandler : IRequestHandler<ProductoQuery, IList<Producto>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IContext _context;
        public ProductoQueryHandler(
            IUnitOfWork  unitOfWork) { 
            this._unitOfWork = unitOfWork;
            this._context = unitOfWork.Context;
        }
        public async Task<IList<Producto>> Handle(ProductoQuery request, CancellationToken cancellationToken)
        {
            var query = from p in _context.Query<Producto>()
                        select new Producto
                        {
                            nombre = p.nombre,
                            codigo = p.codigo,
                            descripcion = p.descripcion
                        };
            return await query.ToListAsync();
        }
    }
}
