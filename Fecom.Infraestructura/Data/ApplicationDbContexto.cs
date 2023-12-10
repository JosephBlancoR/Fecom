using Fecom.Dominio.Entidades;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Fecom.Infraestructura.Data.AplicacionDbContexto;

namespace Fecom.Infraestructura.Data
{
    public class AplicacionDbContexto : IdentityDbContext<ApplicationUser>
    {
        public AplicacionDbContexto(DbContextOptions<AplicacionDbContexto> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<Venta> Ventas { get; set; }


        public class ApplicationUser : IdentityUser
        {
            public string Nombre { get; set; }
        }

        public class ApplicationRole : IdentityRole
        {
            // Puedes personalizar roles si es necesario.
        }
    }
}