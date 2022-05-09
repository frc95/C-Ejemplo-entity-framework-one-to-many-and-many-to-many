using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia.Models;

namespace Persistencia
{
    public class Context : DbContext
    {
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Automovil> AutoMovil { get; set; }
        public DbSet<Moto> Moto { get; set; }

        public DbSet<Desperfecto> Desperfecto { get; set; }
        public DbSet<Repuesto> Repuesto { get; set; }

        public DbSet<Desperfecto_Repuesto> Desperfectos_Repuestos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection = @"Server=DESKTOP-I8354RC;Database=DbTallerMecanico;Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Desperfecto_Repuesto>()
                .HasOne(d => d.Desperfecto)
                .WithMany(dr => dr.Desperfecto_Repuesto)
                .HasForeignKey(di => di.DesperfectoId);

            modelBuilder.Entity<Desperfecto_Repuesto>()
                .HasOne(r => r.Repuesto)
                .WithMany(dr => dr.Desperfecto_Repuesto)
                .HasForeignKey(ri => ri.RepuestoId);
        }

    }
}
