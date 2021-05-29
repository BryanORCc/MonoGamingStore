using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonoGamingStore.Data;
using MonoGamingStore.Models;

namespace MonoGamingStore.Controllers
{
    
    
    public class ContactoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactoController(ApplicationDbContext context){
            _context = context;
        }

        public IActionResult Index(){
            var ListaContacto = _context.DataContactos.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contacto c){
            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(c);
        }

    }
}