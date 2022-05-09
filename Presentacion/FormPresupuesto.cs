using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Persistencia.Models;

namespace Presentacion
{
    public partial class FormPresupuesto : Form
    {
        #region Atributos

        
        private DataGridViewRow presupuesto;
        #endregion

        #region Constructor
        public FormPresupuesto(DataGridViewRow presupuesto)
        {
            InitializeComponent();
            this.presupuesto = presupuesto;

        }
        #endregion

        #region Eventos

        private void FormPresupuesto_Load(object sender, EventArgs e)
        {
            int idVehiculo = (int)this.presupuesto.Cells[4].Value;
            string marca = (string)this.presupuesto.Cells[5].Value;
            string modelo = (string)this.presupuesto.Cells[6].Value;
            string descripcion = "";
            float manoDeObra = 0;
            int tiempoTotal = 0;
            float totalRepuestos = 0;


            List<Desperfecto> desperfectos = this.GetDesperfectos(idVehiculo);

            foreach (Desperfecto d in desperfectos)
            {
                manoDeObra += d.ManoDeObra;
                tiempoTotal += d.Tiempo;
                totalRepuestos += this.GetPrecioTotalRepuestos(d.DesperfectoId);
                descripcion += d.Descripcion + " ";
            }

            int costoEstacionamiento = this.CalcularCostoDeEstacionamiento(tiempoTotal);
            float subTotal = manoDeObra + costoEstacionamiento + totalRepuestos;
            float recargo = this.CalcularRecargo(subTotal);
            float total = recargo + subTotal;

            txtVehiculo.Text = marca + " " + modelo;
            txtPatente.Text = (string)this.presupuesto.Cells[7].Value;
            rtxtbDescripcion.Text = descripcion;
            txtManoObra.Text = "$ " + manoDeObra;
            lblTiempo.Text += " " + tiempoTotal + " hrs";
            txtTiempo.Text = "$ " + costoEstacionamiento;
            txtSubtotal.Text = "$ " + subTotal.ToString("0.00");
            txtDescuento.Text = "$ 0";
            txtRecargo.Text = "$ " + recargo.ToString("0.00");
            txtTotal.Text = "$ " + total.ToString("0.00");

        }
        #endregion

        #region Funciones


        private int CalcularCostoDeEstacionamiento(int tiempo)
        {

            int dias = tiempo / 24;
            int total = 130 * dias;

            if(total == 0)
            {
                total = 130;
            }

            return total;

        }

        private float CalcularRecargo(float subtotal)
        {
            float recargo = subtotal * 0.1f;
            return recargo;
        }

        private List<Repuesto> GetRepuestos(int idDesperfecto)
        {
            return Logica.Desperfecto_Repuesto_DB.GetRepuestosById(idDesperfecto);
        }

        private List<Desperfecto> GetDesperfectos(int vehiculoId)
        {
            return Logica.DesperfectoDB.GetDesperfectosByIdVehiculo(vehiculoId);
        }

        private float GetPrecioTotalRepuestos(int idDesperfectos)
        {

            List<Repuesto> repuestos = this.GetRepuestos(idDesperfectos);
            float total = 0;

            foreach (Repuesto r in repuestos)
            {
                rtxtbRepuestos.Text += "$ " + r.Precio + " " + r.Nombre + "\n";
                total += r.Precio;
            }

            return total;
        }
        #endregion

    }
}
