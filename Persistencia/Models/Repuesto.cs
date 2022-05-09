using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Models
{
    public class Repuesto
    {
        [Key]
        public int RepuestoId { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }

        public List<Desperfecto_Repuesto> Desperfecto_Repuesto { get; set; }
    }
}
