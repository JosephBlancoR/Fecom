using Microsoft.AspNetCore.Mvc;

namespace Fecom.Web.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
