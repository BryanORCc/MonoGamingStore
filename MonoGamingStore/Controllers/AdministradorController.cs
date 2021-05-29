using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MonoGamingStore.Data;
using MonoGamingStore.Models;

namespace MonoGamingStore.Controllers
{
    public class AdministradorController: Controller
    {
        private readonly ApplicationDbContext _context;

        public AdministradorController(ApplicationDbContext context){
            _context = context;
        }

        public IActionResult Admin()
        {
            return View();
        }
        
        public IActionResult producto(){
            var productos = _context.DataProductos.OrderBy(p => p.Nombre).ToList();
            return View(productos);
        }

        //REGISTRAR PRODUCTOS______________________________________________________
        public IActionResult RegistrarProducto(){

            return View();
        }

        [HttpPost]
        public IActionResult RegistrarProducto(Producto p){
            if(ModelState.IsValid){
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction("producto");
            }
            return View(p);
        }

        //MODIFICAR PRODUCTOS______________________________________________________
        public IActionResult ModificarProducto(int id) {
            var producto = _context.DataProductos.Find(id);
            return View(producto);
        }

        [HttpPost]
        public IActionResult ModificarProducto(Producto p) {
            if (ModelState.IsValid) {
                var producto = _context.DataProductos.Find(p.ProductoId);
                producto.Nombre = p.Nombre;
                _context.SaveChanges();
                return RedirectToAction("producto");
            }
            return View(p);
        }


        //ELIMINAR PRODUCTO______________________________________________________
        [HttpPost]
        public IActionResult EliminarProducto(int id) {
            var producto = _context.DataProductos.Find(id);
            _context.Remove(producto);
            _context.SaveChanges();

            return RedirectToAction("producto");
        }


        //_________________________________________________________
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
         public IActionResult mensajes()
        {
            return View();
        }



        
    }
}