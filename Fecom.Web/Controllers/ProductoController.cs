using Fecom.Dominio.Entidades;
using Fecom.Infraestructura.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Fecom.Web.Controllers
{

    public class ProductoController : Controller
    {
        private readonly AplicacionDbContexto _context;

        public ProductoController(AplicacionDbContexto context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            // Lógica para mostrar la lista de productos
            return View(await _context.Productos.ToListAsync());
        }

        public IActionResult Create()
        {
            // Cargar las categorías y proveedores desde la base de datos
            var categorias = _context.Categorias.Select(c => new SelectListItem
            {
                Value = c.CategoriaId.ToString(),
                Text = c.Nombre
            }).ToList();

            var proveedores = _context.Proveedores.Select(p => new SelectListItem
            {
                Value = p.ProveedorId.ToString(),
                Text = p.Nombre
            }).ToList();

            ViewBag.Categorias = categorias;
            ViewBag.Proveedores = proveedores;

            return View();
        }

        // POST: Productos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Precio,Stock,CategoriaId,ProveedorId")] Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            // Cargar las categorías y proveedores desde la base de datos
            ViewBag.Categorias = new SelectList(_context.Categorias, "Id", "Nombre");
            ViewBag.Proveedores = new SelectList(_context.Proveedores, "Id", "Nombre");

            return View(producto);
        }
    }

}

