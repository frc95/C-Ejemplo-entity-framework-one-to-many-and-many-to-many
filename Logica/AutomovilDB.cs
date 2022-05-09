using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;
using Persistencia.Models;
using Enumeradores;

namespace Logica
{
    public class AutomovilDB
    {
        #region Funciones
        public static List<Automovil> GetAutomoviles()
        {
            using (var context = new Context())
            {
                return context.AutoMovil.ToList();
            }
        }

        public static void AddAutomovil(string marca, string modelo, string patente, int tipoAutomovil, int cantidadPuertas)
        {
            using (var context = new Context())
            {
                Automovil auto = new Automovil();
                auto.Marca = marca;
                auto.Modelo = modelo;
                auto.Patente = patente;
                auto.tipo = (Tipo)tipoAutomovil;
                auto.CantidadPuertas = cantidadPuertas;
                context.Vehiculo.Add(auto);

                context.SaveChanges();
            }
                
        }

        public static void DeleteAutomovil(int id)
        {
            using (var context = new Context())
            {
                Automovil a = new Automovil() { VehiculoId = id };
                context.AutoMovil.Attach(a);
                context.AutoMovil.Remove(a);
                context.SaveChanges();
            }
        }
        #endregion
    }
}
