using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MonoGamingStore.Controllers
{
    public class bienvenidaAdminController: Controller
    {
                private readonly ILogger<bienvenidaAdminController> _logger;

        public bienvenidaAdminController(ILogger<bienvenidaAdminController> logger)
        {
            _logger = logger;
        }

        public IActionResult pantalla()
        {
            return View();
        }
    }
}