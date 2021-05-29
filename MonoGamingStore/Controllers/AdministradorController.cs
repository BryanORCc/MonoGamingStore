using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        //-------------------DELETE
        public async Task<IActionResult> EliminarContacto(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contacto = await _context.DataContactos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contacto == null)
            {
                return NotFound();
            }

            return View(contacto);
        }

        // POST: Producto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var contacto = await _context.DataContactos.FindAsync(id);
            _context.DataContactos.Remove(contacto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Mensajes));
        }
        
    }
}