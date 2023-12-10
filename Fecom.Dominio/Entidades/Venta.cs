using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fecom.Dominio.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }

        [Required(ErrorMessage = "El campo Fecha es obligatorio.")]
        [Display(Name = "Fecha de la Venta")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El campo Cliente es obligatorio.")]
        [StringLength(100, ErrorMessage = "El campo Cliente no puede tener más de 100 caracteres.")]
        public string Cliente { get; set; }

        [Required(ErrorMessage = "El campo Total es obligatorio.")]
        [Range(0, double.MaxValue, ErrorMessage = "El Total debe ser mayor o igual a cero.")]
        public decimal Total { get; set; }
    }
}
