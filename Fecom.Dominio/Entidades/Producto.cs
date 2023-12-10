using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecom.Dominio.Entidades
{
    public class Producto
    {
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Nombre no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Precio es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El Precio debe ser mayor o igual a cero.")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "El campo Stock es obligatorio.")]
        [Range(0, int.MaxValue, ErrorMessage = "El Stock debe ser mayor o igual a cero.")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Debes seleccionar una categoría.")]
        public int CategoriaId { get; set; }

        [Required(ErrorMessage = "Debes seleccionar un proveedor.")]
        public int ProveedorId { get; set; }



    }

}
