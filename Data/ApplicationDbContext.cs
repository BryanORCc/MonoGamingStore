using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MonoGamingStore.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MonoGamingStore.Models.Contacto> DataContactos { get; set; }

        public DbSet<MonoGamingStore.Models.Producto> DataProductos { get; set; }
        public DbSet<MonoGamingStore.Models.Carrito> DataCarrito { get; set; }
    }
}
