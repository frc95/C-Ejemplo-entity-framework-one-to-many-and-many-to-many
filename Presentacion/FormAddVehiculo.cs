using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Enumeradores;

namespace Presentacion
{
    public partial class FormAddVehiculo : Form
    {
        #region Constructor
        public FormAddVehiculo()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos

        
        private void FormAddVehiculo_Load(object sender, EventArgs e)
        {
            cmbTipoVehiculo.Items.Add("Automovil");
            cmbTipoVehiculo.Items.Add("Moto");

            cmbTipoAutomovil.DataSource = Enum.GetValues(typeof(Tipo));
            cmbTipoAutomovil.SelectedItem = Tipo.Compacto;

            nudCilindrada.Enabled = false;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            epMarca.Clear();
            epModelo.Clear();
            epPatente.Clear();
            epCantidadPuertas.Clear();
            epCilindrada.Clear();

            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string patente = txtPatente.Text;
            string tipoVehiculo = cmbTipoVehiculo.Text;

            int tipoAutomovil = cmbTipoAutomovil.SelectedIndex;
            int cantidadPuertas = Convert.ToInt32(Math.Round(nudCantidadPuertas.Value, 0));

            int cilindrada = Convert.ToInt32(Math.Round(nudCilindrada.Value, 0));

            bool validarVehiculo = this.ValidacionVehiculo();

            if (tipoVehiculo == "Automovil" && this.ValidarCantidadPuertas() && validarVehiculo)
            {
                Logica.AutomovilDB.AddAutomovil(marca, modelo, patente, tipoAutomovil, cantidadPuertas);
                MessageBox.Show("Vehiculo agregado", "Mensaje");
                this.Close();
            }
            else if(tipoVehiculo == "Moto" && this.ValidarCilindrada() && validarVehiculo)
            {
                Logica.MotoDB.AddMoto(marca, modelo, patente, cilindrada);
                MessageBox.Show("Vehiculo agregado", "Mensaje");
                this.Close();
            }
            

        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTipoVehiculo.SelectedItem.ToString() == "Moto")
            {
                cmbTipoAutomovil.Enabled = false;
                nudCantidadPuertas.Enabled = false;
                nudCilindrada.Enabled = true;
            }
            else
            {
                cmbTipoAutomovil.Enabled = true;
                nudCantidadPuertas.Enabled = true;
                nudCilindrada.Enabled = false;
            }
        }
        #endregion

        #region Funciones

        
        private bool ValidacionVehiculo()
        {
            bool validar = true;
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                epMarca.SetError(txtMarca, "La marca no puede estar vacio");
                validar = false;
            }
            if (string.IsNullOrEmpty(txtModelo.Text))
            {
                epModelo.SetError(txtModelo, "El modelo no puede estar vacio");
                validar = false;
            }
            if (string.IsNullOrEmpty(txtPatente.Text))
            {
                epPatente.SetError(txtPatente, "La patente no puede estar vacio");
                validar = false;
            }

            return validar;
        }

        private bool ValidarCantidadPuertas()
        {
            bool validar = true;
            if (nudCantidadPuertas.Value <= 0)
            {
                epCantidadPuertas.SetError(nudCantidadPuertas, "La cantidad de puertas debe ser mayor que cero");
                validar = false;
            }

            return validar;
        }

        private bool ValidarCilindrada()
        {
            bool validar = true;
            if (nudCilindrada.Value <= 0)
            {
                epCilindrada.SetError(nudCilindrada, "La cilindrada debe ser mayor que cero");
                validar = false;
            }

            return validar;
        }
        #endregion
    }
}
