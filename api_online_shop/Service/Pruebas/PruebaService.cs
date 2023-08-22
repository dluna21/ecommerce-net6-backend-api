using CB.Entidades;
using api_online_shop.Service.Productos.Modelos;
using api_online_shop.Service.Productos.Querys;
using MediatR;
using api_online_shop.Service.Pruebas.Querys;

namespace api_online_shop.Service.Pruebas
{
    public class PruebaService : IPruebaService
    {
        private readonly IMediator _mediator;
        public PruebaService(IMediator mediator)
        {
            this._mediator = mediator;
        }
        public async Task<IList<testModel>> get()
        {
            return await _mediator.Send(new PruebaQuery { 
                nombre = "Test"
            });
        }
    }
}
