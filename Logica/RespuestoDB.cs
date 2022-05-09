using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Persistencia.Models;

namespace Logica
{
    public class RespuestoDB
    {
        #region Funciones
        public static List<Repuesto> GetRespuestos()
        {
            using (var context = new Context())
            {
                return context.Repuesto.ToList();
            }
        }

        public static List<string> GetNombreRepuestos()
        {
            using (var context = new Context())
            {
                return context.Repuesto.Select(x => x.Nombre).ToList();
            }
        }

        public static void AddRepuesto(string nombre, decimal precio)
        {
            using (var context = new Context())
            {
                Repuesto r = new Repuesto();
                r.Nombre = nombre;
                r.Precio = (float)precio;

                context.Repuesto.Add(r);

                context.SaveChanges();
            }

        }

        public static void DeleteRepuesto(int id)
        {
            using (var context = new Context())
            {
                Repuesto r = new Repuesto() { RepuestoId = id };
                context.Repuesto.Attach(r);
                context.Repuesto.Remove(r);
                context.SaveChanges();
            }
        }
        #endregion
    }
}
