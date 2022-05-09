
namespace Presentacion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgAutomovil = new System.Windows.Forms.DataGridView();
            this.idAuto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnAgregarVehiculo = new System.Windows.Forms.Button();
            this.dgMoto = new System.Windows.Forms.DataGridView();
            this.idMoto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminarAuto = new System.Windows.Forms.Button();
            this.btnEliminarMoto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomovil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgAutomovil
            // 
            this.dgAutomovil.AllowUserToAddRows = false;
            this.dgAutomovil.AllowUserToDeleteRows = false;
            this.dgAutomovil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAutomovil.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAuto,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgAutomovil.Location = new System.Drawing.Point(12, 98);
            this.dgAutomovil.Name = "dgAutomovil";
            this.dgAutomovil.ReadOnly = true;
            this.dgAutomovil.RowTemplate.Height = 25;
            this.dgAutomovil.Size = new System.Drawing.Size(693, 224);
            this.dgAutomovil.TabIndex = 0;
            this.dgAutomovil.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAutomovil_CellClick);
            // 
            // idAuto
            // 
            this.idAuto.DataPropertyName = "VehiculoId";
            this.idAuto.HeaderText = "ID";
            this.idAuto.Name = "idAuto";
            this.idAuto.ReadOnly = true;
            this.idAuto.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Marca";
            this.Column2.HeaderText = "MARCA";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Modelo";
            this.Column3.HeaderText = "MODELO";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Patente";
            this.Column4.HeaderText = "PATENTE";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tipo";
            this.Column5.HeaderText = "TIPO";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CantidadPuertas";
            this.Column6.FillWeight = 150F;
            this.Column6.HeaderText = "CANTIDAD DE PUERTAS";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 150;
            // 
            // btnAgregarVehiculo
            // 
            this.btnAgregarVehiculo.Location = new System.Drawing.Point(12, 12);
            this.btnAgregarVehiculo.Name = "btnAgregarVehiculo";
            this.btnAgregarVehiculo.Size = new System.Drawing.Size(113, 23);
            this.btnAgregarVehiculo.TabIndex = 1;
            this.btnAgregarVehiculo.Text = "Agregar Vehiculo";
            this.btnAgregarVehiculo.UseVisualStyleBackColor = true;
            this.btnAgregarVehiculo.Click += new System.EventHandler(this.btnAgregarVehiculo_Click);
            // 
            // dgMoto
            // 
            this.dgMoto.AllowUserToAddRows = false;
            this.dgMoto.AllowUserToDeleteRows = false;
            this.dgMoto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMoto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMoto,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dgMoto.Location = new System.Drawing.Point(12, 345);
            this.dgMoto.Name = "dgMoto";
            this.dgMoto.ReadOnly = true;
            this.dgMoto.RowTemplate.Height = 25;
            this.dgMoto.Size = new System.Drawing.Size(544, 150);
            this.dgMoto.TabIndex = 2;
            this.dgMoto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMoto_CellClick);
            // 
            // idMoto
            // 
            this.idMoto.DataPropertyName = "VehiculoId";
            this.idMoto.HeaderText = "ID";
            this.idMoto.Name = "idMoto";
            this.idMoto.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Marca";
            this.Column8.HeaderText = "MARCA";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Modelo";
            this.Column9.HeaderText = "MODELO";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Patente";
            this.Column10.HeaderText = "PATENTE";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Cilindrada";
            this.Column11.HeaderText = "CILINDRADA";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Automoviles";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Motos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(634, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Repuestos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Ordenes de reparación";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminarAuto
            // 
            this.btnEliminarAuto.Location = new System.Drawing.Point(478, 69);
            this.btnEliminarAuto.Name = "btnEliminarAuto";
            this.btnEliminarAuto.Size = new System.Drawing.Size(227, 23);
            this.btnEliminarAuto.TabIndex = 7;
            this.btnEliminarAuto.Text = "Eliminar automovil";
            this.btnEliminarAuto.UseVisualStyleBackColor = true;
            this.btnEliminarAuto.Click += new System.EventHandler(this.btnEliminarAuto_Click);
            // 
            // btnEliminarMoto
            // 
            this.btnEliminarMoto.Location = new System.Drawing.Point(562, 345);
            this.btnEliminarMoto.Name = "btnEliminarMoto";
            this.btnEliminarMoto.Size = new System.Drawing.Size(143, 23);
            this.btnEliminarMoto.TabIndex = 8;
            this.btnEliminarMoto.Text = "Eliminar Moto";
            this.btnEliminarMoto.UseVisualStyleBackColor = true;
            this.btnEliminarMoto.Click += new System.EventHandler(this.btnEliminarMoto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 507);
            this.Controls.Add(this.btnEliminarMoto);
            this.Controls.Add(this.btnEliminarAuto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMoto);
            this.Controls.Add(this.btnAgregarVehiculo);
            this.Controls.Add(this.dgAutomovil);
            this.Name = "Form1";
            this.Text = "Taller Mecánico";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAutomovil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAgregarVehiculo;
        public System.Windows.Forms.DataGridView dgAutomovil;
        private System.Windows.Forms.DataGridView dgMoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnEliminarAuto;
        private System.Windows.Forms.Button btnEliminarMoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAuto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMoto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
    }
}

