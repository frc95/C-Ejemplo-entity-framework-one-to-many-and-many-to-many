using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumeradores;

namespace Persistencia.Models
{
    public class Automovil : Vehiculo
    {
        public Tipo tipo { get; set; }
        public int CantidadPuertas { get; set; }
    }
}
