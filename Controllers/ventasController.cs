using Microsoft.AspNetCore.Mvc;
using MonoGamingStore.Data;
using MonoGamingStore.Models;
using System.Linq;

namespace MonoGamingStore.Controllers
{
    public class ventasController : Controller
    {

        private readonly ApplicationDbContext _context;
        public ventasController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult venta()
        {
            Carrito c = new Carrito();
            c.ProductoId = int.Parse(ViewData["id"].ToString());
            c.Nombre = ViewData["nombre"].ToString();
            c.Foto = ViewData["foto"].ToString();
            c.Detalle = ViewData["detalle"].ToString();
            c.Precio = double.Parse(ViewData["precio"].ToString());
            c.Categoria = ViewData["categoria"].ToString();

            if(ModelState.IsValid){
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("ventas");
            }
            return View(c);
        }
    }
}