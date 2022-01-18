using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cgn.Models.Entities
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Descripcion { get; set; }
        [Required]
        public double Precio { get; set; }
    }
}
