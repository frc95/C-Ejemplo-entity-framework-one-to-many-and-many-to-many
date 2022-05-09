
namespace Presentacion
{
    partial class OrdenesReparacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richtxtDescripcion = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudTiempo = new System.Windows.Forms.NumericUpDown();
            this.nudManoObra = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbVehiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbRepuesto = new System.Windows.Forms.ComboBox();
            this.btnAgregarRepuesto = new System.Windows.Forms.Button();
            this.dgRepuesto = new System.Windows.Forms.DataGridView();
            this.RepuestoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desperfecto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgOrdenesReparacion = new System.Windows.Forms.DataGridView();
            this.DesperfectoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManoDeObra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehiculoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOrdenReparacion = new System.Windows.Forms.Button();
            this.btnPresupuesto = new System.Windows.Forms.Button();
            this.epManoObra = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBorrarRepuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManoObra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenesReparacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epManoObra)).BeginInit();
            this.SuspendLayout();
            // 
            // richtxtDescripcion
            // 
            this.richtxtDescripcion.Location = new System.Drawing.Point(102, 166);
            this.richtxtDescripcion.Name = "richtxtDescripcion";
            this.richtxtDescripcion.Size = new System.Drawing.Size(405, 124);
            this.richtxtDescripcion.TabIndex = 0;
            this.richtxtDescripcion.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mano de obra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tiempo (Horas)";
            // 
            // nudTiempo
            // 
            this.nudTiempo.Location = new System.Drawing.Point(102, 74);
            this.nudTiempo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudTiempo.Name = "nudTiempo";
            this.nudTiempo.Size = new System.Drawing.Size(404, 23);
            this.nudTiempo.TabIndex = 4;
            // 
            // nudManoObra
            // 
            this.nudManoObra.DecimalPlaces = 2;
            this.nudManoObra.Location = new System.Drawing.Point(103, 24);
            this.nudManoObra.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudManoObra.Name = "nudManoObra";
            this.nudManoObra.Size = new System.Drawing.Size(404, 23);
            this.nudManoObra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vehiculo";
            // 
            // cmbVehiculo
            // 
            this.cmbVehiculo.DisplayMember = "Marca Modelo";
            this.cmbVehiculo.FormattingEnabled = true;
            this.cmbVehiculo.Location = new System.Drawing.Point(102, 120);
            this.cmbVehiculo.Name = "cmbVehiculo";
            this.cmbVehiculo.Size = new System.Drawing.Size(405, 23);
            this.cmbVehiculo.TabIndex = 7;
            this.cmbVehiculo.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbVehiculo_Format);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Respuesto";
            // 
            // cmbRepuesto
            // 
            this.cmbRepuesto.DisplayMember = "Nombre";
            this.cmbRepuesto.FormattingEnabled = true;
            this.cmbRepuesto.Location = new System.Drawing.Point(615, 16);
            this.cmbRepuesto.Name = "cmbRepuesto";
            this.cmbRepuesto.Size = new System.Drawing.Size(153, 23);
            this.cmbRepuesto.TabIndex = 9;
            // 
            // btnAgregarRepuesto
            // 
            this.btnAgregarRepuesto.Location = new System.Drawing.Point(774, 16);
            this.btnAgregarRepuesto.Name = "btnAgregarRepuesto";
            this.btnAgregarRepuesto.Size = new System.Drawing.Size(112, 23);
            this.btnAgregarRepuesto.TabIndex = 10;
            this.btnAgregarRepuesto.Text = "Agregar repuesto";
            this.btnAgregarRepuesto.UseVisualStyleBackColor = true;
            this.btnAgregarRepuesto.Click += new System.EventHandler(this.btnAgregarRepuesto_Click);
            // 
            // dgRepuesto
            // 
            this.dgRepuesto.AllowUserToAddRows = false;
            this.dgRepuesto.AllowUserToDeleteRows = false;
            this.dgRepuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRepuesto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RepuestoId,
            this.Nombre,
            this.Precio,
            this.Desperfecto});
            this.dgRepuesto.Location = new System.Drawing.Point(541, 74);
            this.dgRepuesto.Name = "dgRepuesto";
            this.dgRepuesto.ReadOnly = true;
            this.dgRepuesto.RowTemplate.Height = 25;
            this.dgRepuesto.Size = new System.Drawing.Size(343, 216);
            this.dgRepuesto.TabIndex = 11;
            this.dgRepuesto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRepuesto_CellClick);
            // 
            // RepuestoId
            // 
            this.RepuestoId.DataPropertyName = "RepuestoId";
            this.RepuestoId.HeaderText = "ID";
            this.RepuestoId.Name = "RepuestoId";
            this.RepuestoId.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "NOMBRE";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "PRECIO";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Desperfecto
            // 
            this.Desperfecto.DataPropertyName = "Desperfecto";
            this.Desperfecto.HeaderText = "Column4";
            this.Desperfecto.Name = "Desperfecto";
            this.Desperfecto.ReadOnly = true;
            this.Desperfecto.Visible = false;
            // 
            // dgOrdenesReparacion
            // 
            this.dgOrdenesReparacion.AllowUserToAddRows = false;
            this.dgOrdenesReparacion.AllowUserToDeleteRows = false;
            this.dgOrdenesReparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrdenesReparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DesperfectoId,
            this.Descripcion,
            this.ManoDeObra,
            this.Tiempo,
            this.VehiculoId,
            this.marca,
            this.modelo,
            this.patente});
            this.dgOrdenesReparacion.Location = new System.Drawing.Point(12, 366);
            this.dgOrdenesReparacion.Name = "dgOrdenesReparacion";
            this.dgOrdenesReparacion.ReadOnly = true;
            this.dgOrdenesReparacion.RowTemplate.Height = 25;
            this.dgOrdenesReparacion.Size = new System.Drawing.Size(874, 150);
            this.dgOrdenesReparacion.TabIndex = 12;
            this.dgOrdenesReparacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgOrdenesReparacion_CellClick);
            // 
            // DesperfectoId
            // 
            this.DesperfectoId.DataPropertyName = "DesperfectoId";
            this.DesperfectoId.HeaderText = "ID";
            this.DesperfectoId.Name = "DesperfectoId";
            this.DesperfectoId.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "DESCRIPCIÓN";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // ManoDeObra
            // 
            this.ManoDeObra.DataPropertyName = "ManoDeObra";
            this.ManoDeObra.HeaderText = "MANO DE OBRA";
            this.ManoDeObra.Name = "ManoDeObra";
            this.ManoDeObra.ReadOnly = true;
            this.ManoDeObra.Width = 130;
            // 
            // Tiempo
            // 
            this.Tiempo.DataPropertyName = "Tiempo";
            this.Tiempo.HeaderText = "TIEMPO";
            this.Tiempo.Name = "Tiempo";
            this.Tiempo.ReadOnly = true;
            // 
            // VehiculoId
            // 
            this.VehiculoId.DataPropertyName = "VehiculoId";
            this.VehiculoId.HeaderText = "VEHICULO ID";
            this.VehiculoId.Name = "VehiculoId";
            this.VehiculoId.ReadOnly = true;
            // 
            // marca
            // 
            this.marca.DataPropertyName = "marca";
            this.marca.HeaderText = "MARCA";
            this.marca.Name = "marca";
            this.marca.ReadOnly = true;
            // 
            // modelo
            // 
            this.modelo.DataPropertyName = "modelo";
            this.modelo.HeaderText = "MODELO";
            this.modelo.Name = "modelo";
            this.modelo.ReadOnly = true;
            // 
            // patente
            // 
            this.patente.DataPropertyName = "patente";
            this.patente.HeaderText = "PATENTE";
            this.patente.Name = "patente";
            this.patente.ReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ordenes de reparación";
            // 
            // btnOrdenReparacion
            // 
            this.btnOrdenReparacion.Location = new System.Drawing.Point(12, 322);
            this.btnOrdenReparacion.Name = "btnOrdenReparacion";
            this.btnOrdenReparacion.Size = new System.Drawing.Size(872, 23);
            this.btnOrdenReparacion.TabIndex = 14;
            this.btnOrdenReparacion.Text = "Agregar orden de reparación";
            this.btnOrdenReparacion.UseVisualStyleBackColor = true;
            this.btnOrdenReparacion.Click += new System.EventHandler(this.btnOrdenReparacion_Click);
            // 
            // btnPresupuesto
            // 
            this.btnPresupuesto.Location = new System.Drawing.Point(12, 522);
            this.btnPresupuesto.Name = "btnPresupuesto";
            this.btnPresupuesto.Size = new System.Drawing.Size(872, 23);
            this.btnPresupuesto.TabIndex = 15;
            this.btnPresupuesto.Text = "Ver presupuesto";
            this.btnPresupuesto.UseVisualStyleBackColor = true;
            this.btnPresupuesto.Click += new System.EventHandler(this.btnPresupuesto_Click);
            // 
            // epManoObra
            // 
            this.epManoObra.ContainerControl = this;
            // 
            // btnBorrarRepuesto
            // 
            this.btnBorrarRepuesto.Location = new System.Drawing.Point(774, 45);
            this.btnBorrarRepuesto.Name = "btnBorrarRepuesto";
            this.btnBorrarRepuesto.Size = new System.Drawing.Size(112, 23);
            this.btnBorrarRepuesto.TabIndex = 16;
            this.btnBorrarRepuesto.Text = "Borrar repuesto";
            this.btnBorrarRepuesto.UseVisualStyleBackColor = true;
            this.btnBorrarRepuesto.Click += new System.EventHandler(this.btnBorrarRepuesto_Click);
            // 
            // OrdenesReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 557);
            this.Controls.Add(this.btnBorrarRepuesto);
            this.Controls.Add(this.btnPresupuesto);
            this.Controls.Add(this.btnOrdenReparacion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgOrdenesReparacion);
            this.Controls.Add(this.dgRepuesto);
            this.Controls.Add(this.btnAgregarRepuesto);
            this.Controls.Add(this.cmbRepuesto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nudManoObra);
            this.Controls.Add(this.nudTiempo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richtxtDescripcion);
            this.Name = "OrdenesReparacion";
            this.Text = "Ordenes de reparación";
            this.Load += new System.EventHandler(this.OrdenesReparacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudManoObra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgRepuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrdenesReparacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epManoObra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richtxtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudTiempo;
        private System.Windows.Forms.NumericUpDown nudManoObra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbRepuesto;
        private System.Windows.Forms.Button btnAgregarRepuesto;
        private System.Windows.Forms.DataGridView dgRepuesto;
        private System.Windows.Forms.DataGridView dgOrdenesReparacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOrdenReparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn RepuestoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desperfecto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesperfectoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ManoDeObra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehiculoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn patente;
        private System.Windows.Forms.Button btnPresupuesto;
        private System.Windows.Forms.ErrorProvider epManoObra;
        private System.Windows.Forms.Button btnBorrarRepuesto;
    }
}