using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cgn.Models.Entities
{
    public class Venta
    {
        [Key]
        public int VentaId { get; set; }

        [Required]
        public int Cliente { get; set; }
        public Cliente ID { get; set; }

        [Required]
        public string Producto { get; set; }
        

        [Required]
        public int Cantidad { get; set; }
    }
}
