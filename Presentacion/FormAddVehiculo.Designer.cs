
namespace Presentacion
{
    partial class FormAddVehiculo
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
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPatente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoAutomovil = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nudCantidadPuertas = new System.Windows.Forms.NumericUpDown();
            this.nudCilindrada = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.epMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.epModelo = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPatente = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCantidadPuertas = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCilindrada = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPuertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPatente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCantidadPuertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCilindrada)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(186, 32);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(100, 23);
            this.txtMarca.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(186, 76);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(100, 23);
            this.txtModelo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patente";
            // 
            // txtPatente
            // 
            this.txtPatente.Location = new System.Drawing.Point(186, 124);
            this.txtPatente.Name = "txtPatente";
            this.txtPatente.Size = new System.Drawing.Size(100, 23);
            this.txtPatente.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tipo de vehiculo";
            // 
            // cmbTipoVehiculo
            // 
            this.cmbTipoVehiculo.FormattingEnabled = true;
            this.cmbTipoVehiculo.Location = new System.Drawing.Point(186, 183);
            this.cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            this.cmbTipoVehiculo.Size = new System.Drawing.Size(100, 23);
            this.cmbTipoVehiculo.TabIndex = 7;
            this.cmbTipoVehiculo.Text = "Automovil";
            this.cmbTipoVehiculo.SelectedIndexChanged += new System.EventHandler(this.cmbTipoVehiculo_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipo de automovil";
            // 
            // cmbTipoAutomovil
            // 
            this.cmbTipoAutomovil.FormattingEnabled = true;
            this.cmbTipoAutomovil.Location = new System.Drawing.Point(186, 243);
            this.cmbTipoAutomovil.Name = "cmbTipoAutomovil";
            this.cmbTipoAutomovil.Size = new System.Drawing.Size(100, 23);
            this.cmbTipoAutomovil.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cantidad de puertas";
            // 
            // nudCantidadPuertas
            // 
            this.nudCantidadPuertas.Location = new System.Drawing.Point(186, 289);
            this.nudCantidadPuertas.Name = "nudCantidadPuertas";
            this.nudCantidadPuertas.Size = new System.Drawing.Size(100, 23);
            this.nudCantidadPuertas.TabIndex = 11;
            // 
            // nudCilindrada
            // 
            this.nudCilindrada.Location = new System.Drawing.Point(186, 347);
            this.nudCilindrada.Name = "nudCilindrada";
            this.nudCilindrada.Size = new System.Drawing.Size(100, 23);
            this.nudCilindrada.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cilindrada";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(109, 396);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar vehiculo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // epMarca
            // 
            this.epMarca.ContainerControl = this;
            // 
            // epModelo
            // 
            this.epModelo.ContainerControl = this;
            // 
            // epPatente
            // 
            this.epPatente.ContainerControl = this;
            // 
            // epCantidadPuertas
            // 
            this.epCantidadPuertas.ContainerControl = this;
            // 
            // epCilindrada
            // 
            this.epCilindrada.ContainerControl = this;
            // 
            // FormAddVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nudCilindrada);
            this.Controls.Add(this.nudCantidadPuertas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbTipoAutomovil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTipoVehiculo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPatente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMarca);
            this.Name = "FormAddVehiculo";
            this.Text = "Añadir Vehiculo";
            this.Load += new System.EventHandler(this.FormAddVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadPuertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCilindrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPatente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCantidadPuertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCilindrada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPatente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoVehiculo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoAutomovil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudCantidadPuertas;
        private System.Windows.Forms.NumericUpDown nudCilindrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ErrorProvider epMarca;
        private System.Windows.Forms.ErrorProvider epModelo;
        private System.Windows.Forms.ErrorProvider epPatente;
        private System.Windows.Forms.ErrorProvider epCantidadPuertas;
        private System.Windows.Forms.ErrorProvider epCilindrada;
    }
}