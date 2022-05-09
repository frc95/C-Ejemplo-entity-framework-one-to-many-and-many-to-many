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
    public partial class OrdenesReparacion : Form
    {
        #region Atributos
        private int index;
        private int repuestoIndex;
        private DataGridViewRow dataSelected;
        private DataGridViewRow repuestoSelected;
        #endregion

        #region Constructor
        public OrdenesReparacion()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void OrdenesReparacion_Load(object sender, EventArgs e)
        {
            this.dgRepuesto.Columns["Precio"].DefaultCellStyle.Format = "c";
            this.dgOrdenesReparacion.Columns["ManoDeObra"].DefaultCellStyle.Format = "c";
            this.ListarVehiculos();
            this.ListarRepuestos();
            this.ListarDesperfectos();
        }

        private void cmbVehiculo_Format(object sender, ListControlConvertEventArgs e)
        {
            int Id = ((Vehiculo)e.ListItem).VehiculoId;
            string Marca = ((Vehiculo)e.ListItem).Marca;
            string Modelo = ((Vehiculo)e.ListItem).Modelo;
            e.Value = "ID: " + Id + " " + Marca + " " + Modelo;
        }

        private void btnAgregarRepuesto_Click(object sender, EventArgs e)
        {
            Repuesto r = (Repuesto)cmbRepuesto.SelectedItem;
            dgRepuesto.Rows.Add(r.RepuestoId, r.Nombre, r.Precio);
        }

        private void btnOrdenReparacion_Click(object sender, EventArgs e)
        {
            epManoObra.Clear();

            if (this.ValidarManoObra())
            {
                string descripcion = richtxtDescripcion.Text;
                float manoObra = (float)nudManoObra.Value;
                int tiempo = (int)nudTiempo.Value;

                Vehiculo v = (Vehiculo)cmbVehiculo.SelectedItem;
                int vehiculoId = v.VehiculoId;

                List<int> listRespuesto = new List<int>();
                foreach (DataGridViewRow r in dgRepuesto.Rows)
                {
                    if (r.Cells["RepuestoId"].Value != null)
                    {
                        int aux = (int)r.Cells["RepuestoId"].Value;
                        listRespuesto.Add(aux);
                    }

                }
                int idDesperfecto = Logica.DesperfectoDB.AddDesperfecto(descripcion, manoObra, tiempo, vehiculoId);

                foreach (int idRepuesto in listRespuesto)
                {
                    Logica.Desperfecto_Repuesto_DB.AddDesperfecto_Repuesto(idDesperfecto, idRepuesto);
                }

                this.ListarDesperfectos();
            }
            
            
        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            if(dataSelected != null)
            {
                FormPresupuesto form = new FormPresupuesto(dataSelected);
                form.Show();
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar una orden de reparación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void dgOrdenesReparacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index != -1)
            {
                dataSelected = dgOrdenesReparacion.Rows[index];
            }
        }

        private void btnBorrarRepuesto_Click(object sender, EventArgs e)
        {
            if (repuestoSelected != null)
            {
                dgRepuesto.Rows.Remove(repuestoSelected);
                repuestoSelected = null;
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un repuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgRepuesto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            repuestoIndex = e.RowIndex;

            if (repuestoIndex != -1)
            {
                repuestoSelected = dgRepuesto.Rows[repuestoIndex];
            }
        }
        #endregion

        #region Funciones
        private bool ValidarManoObra()
        {
            bool validar = true;
            if (nudManoObra.Value <= 0)
            {
                epManoObra.SetError(nudManoObra, "La mano de obra debe ser mayor que cero");
                validar = false;
            }

            return validar;
        }

        private void ListarVehiculos()
        {
            cmbVehiculo.DataSource = Logica.VehiculoDB.GetVehiculos();
        }

        private void ListarRepuestos()
        {
            cmbRepuesto.DataSource = Logica.RespuestoDB.GetRespuestos();
        }
        private void ListarDesperfectos()
        {
            dgOrdenesReparacion.DataSource = Logica.DesperfectoDB.GetDesperfectos();
        }
        #endregion

    }
}
