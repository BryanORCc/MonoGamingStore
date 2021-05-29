using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonoGamingStore.Data;
using MonoGamingStore.Models;

namespace MonoGamingStore.Controllers
{
    public class AdministradorController: Controller
    {
        private readonly ILogger<AdministradorController> _logger;
        private readonly ApplicationDbContext _context;

        public AdministradorController(ILogger<AdministradorController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Admin()
        {
            return View();
        }
         public IActionResult producto()
        {
            return View();
        }
         public IActionResult cliente()
        {
            return View();
        }
         public IActionResult ventas()
        {
            return View();
        }
         public IActionResult proveedores()
        {
            return View();
        }
         public IActionResult Mensajes()
        {
            var mensajes = _context.DataContactos.OrderBy(x => x.Id).ToList();
            return View(mensajes);
        }


        
    }
}