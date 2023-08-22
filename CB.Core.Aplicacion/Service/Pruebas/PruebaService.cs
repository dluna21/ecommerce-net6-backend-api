using CB.Entidades; 
using MediatR;
using CB.Core.Aplicacion.Service.Pruebas.Querys;

namespace CB.Core.Aplicacion.Service.Pruebas
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
