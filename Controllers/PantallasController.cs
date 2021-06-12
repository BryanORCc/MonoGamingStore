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
            var iden = 0;
            var nombre = "";
            var foto = "";
            var detalle = "";
            var precio = 0.0;
            var categoria = "";
            var producto = _context.DataProductos.OrderBy(p => p.ProductoId).ToList();
            foreach (var item in producto)
            {
                if(item.ProductoId == id){
                    iden = item.ProductoId;
                    nombre = item.Nombre;
                    foto = item.Foto;
                    detalle = item.Detalle;
                    precio = item.Precio;
                    categoria = item.Categoria;
                    break;
                }
            }
            ViewData["id"] = iden;
            ViewData["nombre"] = nombre;
            ViewData["foto"] = foto;
            ViewData["detalle"] = detalle;
            ViewData["precio"] = precio;
            ViewData["categoria"] = categoria;

            return View();
        }

    }
}