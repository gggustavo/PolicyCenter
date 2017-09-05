namespace View
{
    partial class VehiculoAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculoAddForm));
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirmar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.marcas = new System.Windows.Forms.ComboBox();
            this.versiones = new System.Windows.Forms.ComboBox();
            this.modelos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.versionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ramoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(Model.Marca);
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(Model.Modelo);
            // 
            // confirmar
            // 
            this.confirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmar.BackgroundImage")));
            this.confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmar.FlatAppearance.BorderSize = 0;
            this.confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmar.ForeColor = System.Drawing.Color.Transparent;
            this.confirmar.Location = new System.Drawing.Point(112, 246);
            this.confirmar.Name = "confirmar";
            this.confirmar.Size = new System.Drawing.Size(95, 48);
            this.confirmar.TabIndex = 1;
            this.confirmar.UseVisualStyleBackColor = true;
            this.confirmar.Click += new System.EventHandler(this.confirmar_Click);
            // 
            // cancelar
            // 
            this.cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancelar.BackgroundImage")));
            this.cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelar.FlatAppearance.BorderSize = 0;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.ForeColor = System.Drawing.Color.Transparent;
            this.cancelar.Location = new System.Drawing.Point(224, 245);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 48);
            this.cancelar.TabIndex = 2;
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Version";
            // 
            // marcas
            // 
            this.marcas.DataSource = this.marcaBindingSource;
            this.marcas.DisplayMember = "Nombre";
            this.marcas.FormattingEnabled = true;
            this.marcas.Location = new System.Drawing.Point(106, 73);
            this.marcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marcas.Name = "marcas";
            this.marcas.Size = new System.Drawing.Size(156, 20);
            this.marcas.TabIndex = 0;
            this.marcas.ValueMember = "IdMarca";
            // 
            // versiones
            // 
            this.versiones.DataSource = this.versionBindingSource;
            this.versiones.DisplayMember = "Nombre";
            this.versiones.FormattingEnabled = true;
            this.versiones.Location = new System.Drawing.Point(106, 121);
            this.versiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.versiones.Name = "versiones";
            this.versiones.Size = new System.Drawing.Size(264, 20);
            this.versiones.TabIndex = 4;
            this.versiones.ValueMember = "IdVersion";
            // 
            // modelos
            // 
            this.modelos.DataSource = this.modeloBindingSource;
            this.modelos.DisplayMember = "Nombre";
            this.modelos.FormattingEnabled = true;
            this.modelos.Location = new System.Drawing.Point(106, 97);
            this.modelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelos.Name = "modelos";
            this.modelos.Size = new System.Drawing.Size(262, 20);
            this.modelos.TabIndex = 2;
            this.modelos.ValueMember = "IdModelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Modelo";
            // 
            // versionBindingSource
            // 
            this.versionBindingSource.DataSource = typeof(Model.Version);
            // 
            // precio
            // 
            this.precio.Location = new System.Drawing.Point(106, 146);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(100, 20);
            this.precio.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Año";
            // 
            // anio
            // 
            this.anio.Location = new System.Drawing.Point(106, 172);
            this.anio.Name = "anio";
            this.anio.Size = new System.Drawing.Size(100, 20);
            this.anio.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ramo";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.ramoBindingSource;
            this.comboBox1.DisplayMember = "Nombre";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 198);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 20);
            this.comboBox1.TabIndex = 11;
            this.comboBox1.ValueMember = "IdRamo";
            // 
            // ramoBindingSource
            // 
            this.ramoBindingSource.DataSource = typeof(Model.Ramo);
            // 
            // VehiculoAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(452, 349);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.anio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.versiones);
            this.Controls.Add(this.modelos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.marcas);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.confirmar);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehiculoAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonasAddForm";
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox marcas;
        private System.Windows.Forms.ComboBox versiones;
        private System.Windows.Forms.BindingSource versionBindingSource;
        private System.Windows.Forms.ComboBox modelos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox anio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource ramoBindingSource;
    }
}