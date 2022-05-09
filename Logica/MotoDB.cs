using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Persistencia.Models;

namespace Logica
{
    public class MotoDB
    {
        #region Funciones
        public static List<Moto> GetMotos()
        {
            using (var context = new Context())
            {
                return context.Moto.ToList();
            }
        }
        public static void AddMoto(string marca, string modelo, string patente, int cilindrada)
        {
            using (var context = new Context())
            {
                Moto m = new Moto();
                m.Marca = marca;
                m.Modelo = modelo;
                m.Patente = patente;
                m.Cilindrada = cilindrada;

                context.Moto.Add(m);

                context.SaveChanges();
            }

        }
        public static void DeleteMoto(int id)
        {
            using (var context = new Context())
            {
                Moto m = new Moto() { VehiculoId = id };
                context.Moto.Attach(m);
                context.Moto.Remove(m);
                context.SaveChanges();
            }
        }
        #endregion
    }
}
