namespace View
{
    partial class CotizadorVehiculoForm
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
            this.marcas = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modelos = new System.Windows.Forms.ComboBox();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.versiones = new System.Windows.Forms.ComboBox();
            this.versionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.localidadPersona = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.celularPersona = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cuilPersona = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.emailPersona = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.apellidoPersona = new System.Windows.Forms.TextBox();
            this.nombrePersona = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cotizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cuotas = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.premio = new System.Windows.Forms.TextBox();
            this.prima = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.coberturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marcas
            // 
            this.marcas.DataSource = this.marcaBindingSource;
            this.marcas.DisplayMember = "Nombre";
            this.marcas.FormattingEnabled = true;
            this.marcas.Location = new System.Drawing.Point(71, 28);
            this.marcas.Name = "marcas";
            this.marcas.Size = new System.Drawing.Size(342, 21);
            this.marcas.TabIndex = 0;
            this.marcas.ValueMember = "IdMarca";
            this.marcas.SelectionChangeCommitted += new System.EventHandler(this.marcas_SelectionChangeCommitted);
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(Model.Marca);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // modelos
            // 
            this.modelos.DataSource = this.modeloBindingSource;
            this.modelos.DisplayMember = "Nombre";
            this.modelos.FormattingEnabled = true;
            this.modelos.Location = new System.Drawing.Point(71, 55);
            this.modelos.Name = "modelos";
            this.modelos.Size = new System.Drawing.Size(342, 21);
            this.modelos.TabIndex = 2;
            this.modelos.ValueMember = "IdModelo";
            this.modelos.SelectionChangeCommitted += new System.EventHandler(this.modelos_SelectionChangeCommitted);
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(Model.Modelo);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Version";
            // 
            // versiones
            // 
            this.versiones.DataSource = this.versionBindingSource;
            this.versiones.DisplayMember = "Nombre";
            this.versiones.FormattingEnabled = true;
            this.versiones.Location = new System.Drawing.Point(71, 82);
            this.versiones.Name = "versiones";
            this.versiones.Size = new System.Drawing.Size(342, 21);
            this.versiones.TabIndex = 4;
            this.versiones.ValueMember = "IdVersion";
            this.versiones.SelectionChangeCommitted += new System.EventHandler(this.versiones_SelectionChangeCommitted);
            // 
            // versionBindingSource
            // 
            this.versionBindingSource.DataSource = typeof(Model.Version);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.precio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.marcas);
            this.groupBox1.Controls.Add(this.versiones);
            this.groupBox1.Controls.Add(this.modelos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(457, 143);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificación del Vehiculo";
            // 
            // precio
            // 
            this.precio.Enabled = false;
            this.precio.Location = new System.Drawing.Point(72, 110);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 20);
            this.precio.TabIndex = 7;
            this.precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.localidadPersona);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.celularPersona);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cuilPersona);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.emailPersona);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buscar);
            this.groupBox2.Controls.Add(this.apellidoPersona);
            this.groupBox2.Controls.Add(this.nombrePersona);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(498, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(648, 143);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Identificación Persona";
            // 
            // localidadPersona
            // 
            this.localidadPersona.Enabled = false;
            this.localidadPersona.Location = new System.Drawing.Point(355, 94);
            this.localidadPersona.Name = "localidadPersona";
            this.localidadPersona.Size = new System.Drawing.Size(181, 20);
            this.localidadPersona.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Localidad";
            // 
            // celularPersona
            // 
            this.celularPersona.Enabled = false;
            this.celularPersona.Location = new System.Drawing.Point(71, 94);
            this.celularPersona.Name = "celularPersona";
            this.celularPersona.Size = new System.Drawing.Size(202, 20);
            this.celularPersona.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(26, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Celular";
            // 
            // cuilPersona
            // 
            this.cuilPersona.Enabled = false;
            this.cuilPersona.Location = new System.Drawing.Point(355, 65);
            this.cuilPersona.Name = "cuilPersona";
            this.cuilPersona.Size = new System.Drawing.Size(181, 20);
            this.cuilPersona.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cuil";
            // 
            // emailPersona
            // 
            this.emailPersona.Enabled = false;
            this.emailPersona.Location = new System.Drawing.Point(71, 65);
            this.emailPersona.Name = "emailPersona";
            this.emailPersona.Size = new System.Drawing.Size(202, 20);
            this.emailPersona.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(552, 26);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(76, 23);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // apellidoPersona
            // 
            this.apellidoPersona.Location = new System.Drawing.Point(355, 28);
            this.apellidoPersona.Name = "apellidoPersona";
            this.apellidoPersona.Size = new System.Drawing.Size(181, 20);
            this.apellidoPersona.TabIndex = 3;
            // 
            // nombrePersona
            // 
            this.nombrePersona.Location = new System.Drawing.Point(71, 28);
            this.nombrePersona.Name = "nombrePersona";
            this.nombrePersona.Size = new System.Drawing.Size(202, 20);
            this.nombrePersona.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(305, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // cotizar
            // 
            this.cotizar.Location = new System.Drawing.Point(13, 235);
            this.cotizar.Name = "cotizar";
            this.cotizar.Size = new System.Drawing.Size(75, 29);
            this.cotizar.TabIndex = 8;
            this.cotizar.Text = "Cotizar";
            this.cotizar.UseVisualStyleBackColor = true;
            this.cotizar.Click += new System.EventHandler(this.cotizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cuotas);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.premio);
            this.groupBox3.Controls.Add(this.prima);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(498, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 60);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información de la Cotización";
            // 
            // cuotas
            // 
            this.cuotas.Enabled = false;
            this.cuotas.Location = new System.Drawing.Point(534, 27);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(83, 20);
            this.cuotas.TabIndex = 10;
            this.cuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(464, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "6 Cuotas de";
            // 
            // premio
            // 
            this.premio.Enabled = false;
            this.premio.Location = new System.Drawing.Point(295, 27);
            this.premio.Name = "premio";
            this.premio.Size = new System.Drawing.Size(83, 20);
            this.premio.TabIndex = 8;
            this.premio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // prima
            // 
            this.prima.Enabled = false;
            this.prima.Location = new System.Drawing.Point(70, 27);
            this.prima.Name = "prima";
            this.prima.Size = new System.Drawing.Size(83, 20);
            this.prima.TabIndex = 7;
            this.prima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Premio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Prima";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.comboBox1);
            this.groupBox4.Location = new System.Drawing.Point(13, 162);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 60);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cobertura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tipos";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.coberturaBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IdCobertura";
            // 
            // coberturaBindingSource
            // 
            this.coberturaBindingSource.DataSource = typeof(Model.Cobertura);
            // 
            // CotizadorVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 304);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cotizar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CotizadorVehiculoForm";
            this.ShowInTaskbar = false;
            this.Text = "Cotizador Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox marcas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox modelos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox versiones;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private System.Windows.Forms.BindingSource versionBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cuilPersona;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailPersona;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.TextBox apellidoPersona;
        private System.Windows.Forms.TextBox nombrePersona;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox localidadPersona;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox celularPersona;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cotizar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox premio;
        private System.Windows.Forms.TextBox prima;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource coberturaBindingSource;
        private System.Windows.Forms.TextBox cuotas;
        private System.Windows.Forms.Label label14;
    }
}