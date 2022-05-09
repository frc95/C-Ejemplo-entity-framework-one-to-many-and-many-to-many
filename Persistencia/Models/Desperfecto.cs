using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Models
{
    public class Desperfecto
    {
        [Key]
        public int DesperfectoId { get; set; }
        public string Descripcion { get; set; }
        public float ManoDeObra { get; set; }
        public int Tiempo { get; set; }

        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public List<Desperfecto_Repuesto> Desperfecto_Repuesto { get; set; }
    }
}
