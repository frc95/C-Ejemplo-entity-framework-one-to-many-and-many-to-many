using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Models
{
    public class Desperfecto_Repuesto
    {
        public int Id { get; set; }

        public int DesperfectoId { get; set; }
        public Desperfecto Desperfecto { get; set; }


        public int RepuestoId { get; set; }
        public Repuesto Repuesto { get; set; }

    }
}
