using Microsoft.AspNetCore.Mvc;

namespace Conceptos.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
