using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Persistencia.Models;

namespace Logica
{
    public class VehiculoDB
    {
        #region Funciones
        public static List<Vehiculo> GetVehiculos()
        {
            using (var context = new Context())
            {
                return context.Vehiculo.ToList();
            }
        }

        
        #endregion
    }
}
