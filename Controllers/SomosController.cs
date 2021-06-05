using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MonoGamingStore.Controllers
{
    public class SomosController : Controller
    {
        private readonly ILogger<SomosController> _logger;

        public SomosController(ILogger<SomosController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(){
            return View();
        }
    }
}