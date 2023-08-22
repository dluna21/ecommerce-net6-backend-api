using api_online_shop.Service.Productos.Modelos;
using api_online_shop.Service.Productos.Querys;
using MediatR;

namespace api_online_shop.Service.Productos
{
    public class ProductoService
    {
        private readonly IMediator _mediator;

        public ProductoService(IMediator mediator) { 
            this._mediator = mediator;
        }

        public async Task<IList<Producto>> get(string nombreProducto) {

            return await _mediator.Send(new ProductoQuery
            {
                nombre = nombreProducto
            });
        }
    }
}
