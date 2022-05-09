using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persistencia;
using Persistencia.Models;

namespace Logica
{
    public class DesperfectoDB
    {
        #region Funciones
        public static int AddDesperfecto(string descripcion, float manoObra, int tiempo, int vehiculoId)
        {
            using (var context = new Context())
            {
                Desperfecto d = new Desperfecto ();
                d.Descripcion = descripcion;
                d.ManoDeObra = manoObra;
                d.Tiempo = tiempo;
                d.VehiculoId = vehiculoId;

                context.Desperfecto.Add(d);

                context.SaveChanges();

                return d.DesperfectoId;
            }

        }

        public static dynamic GetDesperfectos()
        {
            using (var context = new Context())
            {

                
                var data = (from d in context.Desperfecto.ToList()
                                join v in context.Vehiculo
                                on d.VehiculoId equals v.VehiculoId
                                select new { 
                                    d.DesperfectoId,
                                    d.Descripcion,
                                    d.ManoDeObra,
                                    d.Tiempo,
                                    d.VehiculoId,
                                    marca = v.Marca,
                                    modelo = v.Modelo,
                                    patente = v.Patente}).ToList();

                return data;
            }
        }

        public static List<Desperfecto> GetDesperfectosByIdVehiculo(int vehiculoId)
        {
            using (var context = new Context())
            {
                return context.Desperfecto.Where(x => x.VehiculoId == vehiculoId).ToList();
            }
        }

        
        #endregion
    }
}
