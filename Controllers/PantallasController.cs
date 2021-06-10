using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonoGamingStore.Data;
using MonoGamingStore.Models;

namespace MonoGamingStore.Controllers
{
    public class PantallasController : Controller
    {
        private readonly ILogger<PantallasController> _logger;
        private readonly ApplicationDbContext _context;

        public PantallasController(ILogger<PantallasController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Monitores()
        {
            var monitores = _context.DataProductos.OrderBy(p => p.ProductoId).ToList();
            return View(monitores);
        }

        public IActionResult Graficas()
        {
            return View();
        }
        public IActionResult Cases()
        {
            return View();
        }
        public IActionResult Procesadores()
        {
            return View();
        }
        public IActionResult Detalle()
        {
            return View();
        }

    }
}