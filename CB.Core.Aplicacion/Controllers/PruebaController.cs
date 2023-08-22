using CB.Core.Aplicacion.Service.Pruebas;
using CB.Entidades;
using Microsoft.AspNetCore.Mvc;
using Release.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CB.Core.Aplicacion.Controllers
{
    [ApiController] 
    [Route("[controller]/[action]")]
    public class PruebaController : ControllerBase
    {
        private readonly IPruebaService _pruebaService;

        public PruebaController(IPruebaService pruebaService)
        {
            this._pruebaService = pruebaService;
        }

        [HttpGet]
        public async Task<StatusResponse<IList<testModel>>> getOnlineShop1()
        {
            var data = await this._pruebaService.get();

            return new StatusResponse<IList<testModel>>
            {
                Success = data.Any(),
                Data = data
            };
        }
        [HttpPost]
        public async Task<StatusResponse> Get()
        {
            return new StatusResponse<string>
            {
                Success = true,
                Data = "Hola"
            };
        }
    }
}
