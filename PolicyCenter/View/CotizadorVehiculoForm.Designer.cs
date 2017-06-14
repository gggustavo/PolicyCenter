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
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // marcas
            // 
            this.marcas.DataSource = this.marcaBindingSource;
            this.marcas.DisplayMember = "Nombre";
            this.marcas.FormattingEnabled = true;
            this.marcas.Location = new System.Drawing.Point(72, 12);
            this.marcas.Name = "marcas";
            this.marcas.Size = new System.Drawing.Size(185, 21);
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
            this.label1.Location = new System.Drawing.Point(31, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // modelos
            // 
            this.modelos.DataSource = this.modeloBindingSource;
            this.modelos.DisplayMember = "IdModelo";
            this.modelos.FormattingEnabled = true;
            this.modelos.Location = new System.Drawing.Point(72, 39);
            this.modelos.Name = "modelos";
            this.modelos.Size = new System.Drawing.Size(185, 21);
            this.modelos.TabIndex = 2;
            this.modelos.ValueMember = "Nombre";
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(Model.Modelo);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Version";
            // 
            // versiones
            // 
            this.versiones.DataSource = this.versionBindingSource;
            this.versiones.DisplayMember = "IdVersion";
            this.versiones.FormattingEnabled = true;
            this.versiones.Location = new System.Drawing.Point(72, 66);
            this.versiones.Name = "versiones";
            this.versiones.Size = new System.Drawing.Size(185, 21);
            this.versiones.TabIndex = 4;
            this.versiones.ValueMember = "Nombre";
            // 
            // versionBindingSource
            // 
            this.versionBindingSource.DataSource = typeof(Model.Version);
            // 
            // CotizadorVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.versiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modelos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CotizadorVehiculoForm";
            this.ShowInTaskbar = false;
            this.Text = "Cotizador Vehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}