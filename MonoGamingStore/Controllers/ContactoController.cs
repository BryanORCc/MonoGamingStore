using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MonoGamingStore.Controllers
{
    public class ContactoController : Controller
    {
        
        public IActionResult Index(){
            return View();
        }

    }
}