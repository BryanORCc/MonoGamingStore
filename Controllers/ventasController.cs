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
            var listar = _context.DataCarrito.OrderBy(p => p.ProductoId).ToList();
            return View(listar);
        }

        public IActionResult Agregar(int id)
        {
            var listar = _context.DataProductos.Find(id);
            Carrito c = new Carrito();
            c.ProductoId = listar.ProductoId;
            c.Nombre = listar.Nombre;
            c.Foto = listar.Foto;
            c.Detalle = listar.Detalle;
            c.Precio = listar.Precio;
            c.Categoria = listar.Categoria;

            if (ModelState.IsValid)
            {
                _context.Add(c);
                _context.SaveChanges();
                return RedirectToAction("venta");
            }
            return View(c);
        }

        [HttpPost]
        public IActionResult Eliminar(int id)
        {
            var compra = _context.DataCarrito.Find(id);
            _context.Remove(compra);
            _context.SaveChanges();
            return RedirectToAction("venta");
        }

        public IActionResult Tarjeta()
        {

            return View();
        }




    }
}