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
    public partial class Form1 : Form
    {
        #region Atributo
        private int indexAuto;
        private int indexMoto;
        private DataGridViewRow autoSelected;
        private DataGridViewRow motoSelected;
        #endregion

        #region Constructor
        public Form1()
        {
            
            InitializeComponent();
        }
        #endregion

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActualizarAutomoviles();
            this.ActualizarMotos();
        }

        private void btnAgregarVehiculo_Click(object sender, EventArgs e)
        {
            FormAddVehiculo form = new FormAddVehiculo();
            form.ShowDialog();
            this.ActualizarAutomoviles();
            this.ActualizarMotos();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRepuestos form = new FormRepuestos();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrdenesReparacion form = new OrdenesReparacion();
            form.ShowDialog();
        }
        private void btnEliminarAuto_Click(object sender, EventArgs e)
        {
            if (autoSelected != null)
            {

                if (MessageBox.Show("Esta seguro de querer eliminar el automovil?", "Eliminar automovil", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)autoSelected.Cells["idAuto"].Value;
                    Logica.AutomovilDB.DeleteAutomovil(id);
                    this.ActualizarAutomoviles();
                    autoSelected = null;
                }
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar un automovil", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarMoto_Click(object sender, EventArgs e)
        {
            if (motoSelected != null)
            {

                if (MessageBox.Show("Esta seguro de querer eliminar la moto?", "Eliminar moto", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = (int)motoSelected.Cells["idMoto"].Value;
                    Logica.MotoDB.DeleteMoto(id);
                    this.ActualizarMotos();
                    motoSelected = null;
                }
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar una moto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgMoto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexMoto = e.RowIndex;

            if (indexMoto != -1)
            {
                motoSelected = dgMoto.Rows[indexMoto];
            }
        }

        private void dgAutomovil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexAuto = e.RowIndex;

            if (indexAuto != -1)
            {
                autoSelected = dgAutomovil.Rows[indexAuto];
            }
        }

        #endregion

        #region Funciones
        private void ActualizarAutomoviles()
        {
            dgAutomovil.DataSource = Logica.AutomovilDB.GetAutomoviles();
        }

        private void ActualizarMotos()
        {
            dgMoto.DataSource = Logica.MotoDB.GetMotos();
        }
        #endregion

        
    }
}
