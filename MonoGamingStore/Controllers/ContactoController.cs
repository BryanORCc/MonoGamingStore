using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MonoGamingStore.Data;
using MonoGamingStore.Models;

namespace MonoGamingStore.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;
        private readonly ApplicationDbContext _context;

        public ContactoController(ILogger<ContactoController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }
        public IActionResult Index(){
            var listaMensajes=_context.DataContactos.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Contacto c)
        {
            c.Fecha = DateTime.Now.ToString();
            if (ModelState.IsValid) {
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("ConfirmacionContacto");
            }
            return View(c);
        }
        public IActionResult ConfirmacionContacto(){
            return View();
        }

    }
}