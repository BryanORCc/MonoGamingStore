using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MonoGamingStore.Controllers
{
    public class SiguenosController : Controller
    {
        private readonly ILogger<SiguenosController> _logger;

        public SiguenosController(ILogger<SiguenosController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(){
            return View();
        }
    }
}