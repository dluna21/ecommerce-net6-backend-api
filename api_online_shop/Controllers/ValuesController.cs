using CB.Entidades;
using api_online_shop.context;
using Microsoft.AspNetCore.Mvc;
using Release.Helper;
using System.Linq;

namespace api_online_shop.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")] 
    public class ValuesController : ControllerBase
    {
        private readonly OnlineShopDataContext context;
        public ValuesController(OnlineShopDataContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public StatusResponse getOnlineShop()
        {
            var response = new StatusResponse();

            var concurso = this.context.test.ToList();

            List<testModel> listModel = new List<testModel>();
            foreach (var item in concurso)
            {
                listModel.Add(item);
            }

            //var concurso = this.context.onlineShop.ToList();

            //List<OnlineShop> listModel = new List<OnlineShop>();
            //foreach (var item in concurso)
            //{
            //    listModel.Add(item);
            //}

            response.Success = true;
            
            response.Data = listModel;
            return response;
        }

        [HttpGet]
        // POST: OnlineShopController/Create 
        public StatusResponse saveOnlineshop()
        {
            var response = new StatusResponse();
            //OnlineShop online = new OnlineShop();
            //online.Anio = 2023;
            //online.Periodo = 1;
            //online.Nombre = "Tay Loy";
            //online.BasesDocumentacion = "-";
            //online.BasesPublicacion = DateTime.Now;
            //online.Registro = DateTime.Now;
            //online.UsuarioRegistro = "44836469";

            //this.context.onlineShop.Add(online);

            testModel mod = new testModel();
            mod.nombre1 = "prueba 2";
            mod.fecha1 = DateTime.Now;
            this.context.Add(mod);
            this.context.SaveChanges();

            response.Success = true;
            response.Data = "Registrado";
            return response;

        }
    }
}
