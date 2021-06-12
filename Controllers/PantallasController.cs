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
            var graficas = _context.DataProductos.OrderBy(p => p.ProductoId).ToList();
            return View(graficas);
        }
        public IActionResult Cases()
        {
            var cases = _context.DataProductos.OrderBy(p => p.ProductoId).ToList();
            return View(cases);
        }
        public IActionResult Procesadores()
        {
            var procesadores = _context.DataProductos.OrderBy(p => p.ProductoId).ToList();
            return View(procesadores);
        }
        public IActionResult Rams()
        {
            var rams = _context.DataProductos.OrderBy(p => p.ProductoId).ToList();
            return View(rams);
        }
        public IActionResult Placas()
        {
            var placas = _context.DataProductos.OrderBy(p => p.ProductoId).ToList();
            return View(placas);
        }
        public IActionResult Detalle(int id)
        {
            var nombre = "";
            var foto = "";
            var detalle = "";
            var precio = 0.0;
            var categoria = "";
            var producto = _context.DataProductos.OrderBy(p => p.ProductoId).ToList();
            foreach (var item in producto)
            {
                if(item.ProductoId == id){
                    nombre = item.Nombre;
                    foto = item.Foto;
                    detalle = item.Detalle;
                    precio = item.Precio;
                    categoria = item.Categoria;
                    break;
                }
            }
            ViewData["nombre"] = nombre;
            ViewData["foto"] = foto;
            ViewData["detalle"] = detalle;
            ViewData["precio"] = precio;
            ViewData["categoria"] = categoria;

            return View();
        }

        // Buscador Monitores
        [HttpPost]
        public IActionResult Monitores(string x)
        {
            var monitores = _context.DataProductos.Where(p => p.Nombre.Equals(x)).Where(p => p.Categoria.Equals("Monitor")).ToList();
            if(monitores.Count == 0){
                return RedirectToAction("ProductoNoEncontrado");
            }else{
                return View(monitores);
            }
        }
        [HttpPost]
        public IActionResult Cases(string x)
        {
            var cases = _context.DataProductos.Where(p => p.Nombre.Equals(x)).Where(p => p.Categoria.Equals("Case")).ToList();
            if(cases.Count == 0){
                return RedirectToAction("ProductoNoEncontrado");
            }else{
                return View(cases);
            }
        }
        [HttpPost]
        public IActionResult Graficas(string x)
        {
            var graficas = _context.DataProductos.Where(p => p.Nombre.Equals(x)).Where(p => p.Categoria.Equals("Grafica")).ToList();
            if(graficas.Count == 0){
                return RedirectToAction("ProductoNoEncontrado");
            }else{
                return View(graficas);
            }
        }
        [HttpPost]
        public IActionResult Placas(string x)
        {
            var placas = _context.DataProductos.Where(p => p.Nombre.Equals(x)).Where(p => p.Categoria.Equals("Placa Madre")).ToList();
            if(placas.Count == 0){
                return RedirectToAction("ProductoNoEncontrado");
            }else{
                return View(placas);
            }
        }
        [HttpPost]
        public IActionResult Procesadores(string x)
        {
            var procesadores = _context.DataProductos.Where(p => p.Nombre.Equals(x)).Where(p => p.Categoria.Equals("Procesador")).ToList();
            if(procesadores.Count == 0){
                return RedirectToAction("ProductoNoEncontrado");
            }else{
                return View(procesadores);
            }
        }
        [HttpPost]
        public IActionResult Rams(string x)
        {
            var rams = _context.DataProductos.Where(p => p.Nombre.Equals(x)).Where(p => p.Categoria.Equals("Ram")).ToList();
            if(rams.Count == 0){
                return RedirectToAction("ProductoNoEncontrado");
            }else{
                return View(rams);
            }
        }

        public IActionResult ProductoNoEncontrado()
        {
            return View();
        }

        //Filtro Precios
        public IActionResult MonitoresPrecios(string x)
        {
            var monitores = _context.DataProductos.Where(p => p.Precio.Equals(x)).Where(p => p.Categoria.Equals("Ram")).ToList();
            if(monitores.Count == 0){
                return RedirectToAction("ProductoNoEncontrado");
            }else{
                return View(monitores);
            }
        }
    }
}