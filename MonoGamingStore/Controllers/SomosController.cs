using Microsoft.AspNetCore.Mvc;

namespace MonoGamingStore.Controllers
{
    public class SomosController : Controller
    {
        public IActionResult Index(){
            return View();
        }
    }
}