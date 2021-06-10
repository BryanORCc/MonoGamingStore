using Microsoft.AspNetCore.Mvc;

namespace MonoGamingStore.Controllers
{
    public class ventasController : Controller
    {

        public IActionResult venta()
        {
            return View();
        }
    }
}