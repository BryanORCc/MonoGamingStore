using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonoGamingStore.Models;

namespace MonoGamingStore.Controllers
{
    public class PantallasController : Controller
    {
        private readonly ILogger<PantallasController> _logger;

        public PantallasController(ILogger<PantallasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Monitores()
        {
            return View();
        }


    }
}