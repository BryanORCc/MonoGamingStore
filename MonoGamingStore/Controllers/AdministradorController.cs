using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MonoGamingStore.Controllers
{
    public class AdministradorController: Controller
    {
                private readonly ILogger<AdministradorController> _logger;

        public AdministradorController(ILogger<AdministradorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Admin()
        {
            return View();
        }
    }
}