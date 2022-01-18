using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cgn.Models.Entities
{
    public class Cliente
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]

        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

    }
}
