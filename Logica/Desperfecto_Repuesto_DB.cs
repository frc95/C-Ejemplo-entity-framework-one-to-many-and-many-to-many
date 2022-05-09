using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Persistencia.Models;

namespace Logica
{
    public class Desperfecto_Repuesto_DB
    {
        #region Funciones
        public static void AddDesperfecto_Repuesto(int DesperfectoId, int RepuestoId)
        {
            using (var context = new Context())
            {
                Desperfecto_Repuesto dr = new Desperfecto_Repuesto();
               
                dr.DesperfectoId = DesperfectoId;
                dr.RepuestoId = RepuestoId;

                context.Desperfectos_Repuestos.Add(dr);

                context.SaveChanges();
            }

        }

        public static List<Repuesto> GetRepuestosById(int DesperfectoId)
        {
            using (var context = new Context())
            {
                List<Repuesto> data = (from dr in context.Desperfectos_Repuestos.ToList()
                                      from r in context.Repuesto.ToList()
                                      where dr.DesperfectoId == DesperfectoId && r.RepuestoId == dr.RepuestoId
                                      select r).ToList();
                            

                return data;
            }
        }
        #endregion
    }
}
