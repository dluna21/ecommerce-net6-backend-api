using CB.Entidades;
using api_online_shop.context;
using Microsoft.AspNetCore.Mvc;
using Release.Helper;
using System.Linq;
using api_online_shop.Service.Pruebas;

namespace api_online_shop.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")] 
    public class ValuesController : ControllerBase
    {
 
        private readonly IPruebaService _pruebaService;
        public ValuesController(IPruebaService pruebaService)
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

        //[HttpGet]
        //public StatusResponse getOnlineShop()
        //{
        //    var response = new StatusResponse();

        //    var concurso = this.context.test.ToList();

        //    List<testModel> listModel = new List<testModel>();
        //    foreach (var item in concurso)
        //    {
        //        listModel.Add(item);
        //    }
  
        //    response.Success = true;
            
        //    response.Data = listModel;
        //    return response;
        //}

        //[HttpGet]
        //// POST: OnlineShopController/Create 
        //public StatusResponse saveOnlineshop()
        //{ 
        //    testModel mod = new testModel();
        //    mod.nombre1 = "prueba 2";
        //    mod.fecha1 = DateTime.Now;
        //    this.context.Add(mod);
        //    this.context.SaveChanges();

        //    response.Success = true;
        //    response.Data = "Registrado";
        //    return response;

        //}
    }
}
