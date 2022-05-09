using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRepuestos : Form
    {
        #region Atributos
        private int index;
        private DataGridViewRow dataSelected;
        #endregion

        #region Constructor
        public FormRepuestos()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void FormRepuestos_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns["Precio"].DefaultCellStyle.Format = "c";
            this.ActualizarRespuestos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            epNombre.Clear();
            epPrecio.Clear();
            
            if (this.ValidarCampos())
            {
                string nombre = txtNombre.Text;
                decimal precio = nudPrecio.Value;
                Logica.RespuestoDB.AddRepuesto(nombre, precio);
                this.ActualizarRespuestos();
            } 
            
        }

        private void btnEliminarRepuesto_Click(object sender, EventArgs e)
        {
            if (dataSelected != null)
            { 
            
                if (MessageBox.Show("Esta seguro de querer eliminar el repuesto?", "Eliminar repuesto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)dataSelected.Cells[1].Value;
                    Logica.RespuestoDB.DeleteRepuesto(id);
                    this.ActualizarRespuestos();
                    dataSelected = null;
                }
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un repuesto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            if (index != -1)
            {
                dataSelected = dataGridView1.Rows[index];
            }
        }
        #endregion

        #region Funciones
        private bool ValidarCampos()
        {
            bool validar = true;
            if(string.IsNullOrEmpty(txtNombre.Text))
            {
                epNombre.SetError(txtNombre, "El nombre no puede estar vacio");
                validar = false;
            }
            if (nudPrecio.Value <= 0)
            {
                epPrecio.SetError(nudPrecio, "El precio debe ser mayor que cero");
                validar = false;
            }

            return validar;
        }

        private void ActualizarRespuestos()
        {
            dataGridView1.DataSource = Logica.RespuestoDB.GetRespuestos();
        }
        #endregion

        
    }
}
