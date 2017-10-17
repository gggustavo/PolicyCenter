namespace View
{
    partial class VehiculosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehiculosForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idMarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idModeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVersionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idRamoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ramoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agregar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.reinciar = new System.Windows.Forms.Button();
            this.editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarcaDataGridViewTextBoxColumn,
            this.marcaDataGridViewTextBoxColumn,
            this.idModeloDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.idVersionDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.idBienDataGridViewTextBoxColumn,
            this.idRamoDataGridViewTextBoxColumn,
            this.ramoDataGridViewTextBoxColumn,
            this.anioDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vehiculoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1116, 249);
            this.dataGridView1.TabIndex = 0;
            // 
            // idMarcaDataGridViewTextBoxColumn
            // 
            this.idMarcaDataGridViewTextBoxColumn.DataPropertyName = "IdMarca";
            this.idMarcaDataGridViewTextBoxColumn.HeaderText = "IdMarca";
            this.idMarcaDataGridViewTextBoxColumn.Name = "idMarcaDataGridViewTextBoxColumn";
            this.idMarcaDataGridViewTextBoxColumn.Visible = false;
            // 
            // marcaDataGridViewTextBoxColumn
            // 
            this.marcaDataGridViewTextBoxColumn.DataPropertyName = "Marca";
            this.marcaDataGridViewTextBoxColumn.HeaderText = "Marca";
            this.marcaDataGridViewTextBoxColumn.Name = "marcaDataGridViewTextBoxColumn";
            this.marcaDataGridViewTextBoxColumn.Width = 200;
            // 
            // idModeloDataGridViewTextBoxColumn
            // 
            this.idModeloDataGridViewTextBoxColumn.DataPropertyName = "IdModelo";
            this.idModeloDataGridViewTextBoxColumn.HeaderText = "IdModelo";
            this.idModeloDataGridViewTextBoxColumn.Name = "idModeloDataGridViewTextBoxColumn";
            this.idModeloDataGridViewTextBoxColumn.Visible = false;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.Width = 150;
            // 
            // idVersionDataGridViewTextBoxColumn
            // 
            this.idVersionDataGridViewTextBoxColumn.DataPropertyName = "IdVersion";
            this.idVersionDataGridViewTextBoxColumn.HeaderText = "IdVersion";
            this.idVersionDataGridViewTextBoxColumn.Name = "idVersionDataGridViewTextBoxColumn";
            this.idVersionDataGridViewTextBoxColumn.Visible = false;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.Width = 200;
            // 
            // idBienDataGridViewTextBoxColumn
            // 
            this.idBienDataGridViewTextBoxColumn.DataPropertyName = "IdBien";
            this.idBienDataGridViewTextBoxColumn.HeaderText = "IdBien";
            this.idBienDataGridViewTextBoxColumn.Name = "idBienDataGridViewTextBoxColumn";
            this.idBienDataGridViewTextBoxColumn.Visible = false;
            // 
            // idRamoDataGridViewTextBoxColumn
            // 
            this.idRamoDataGridViewTextBoxColumn.DataPropertyName = "IdRamo";
            this.idRamoDataGridViewTextBoxColumn.HeaderText = "IdRamo";
            this.idRamoDataGridViewTextBoxColumn.Name = "idRamoDataGridViewTextBoxColumn";
            this.idRamoDataGridViewTextBoxColumn.Visible = false;
            // 
            // ramoDataGridViewTextBoxColumn
            // 
            this.ramoDataGridViewTextBoxColumn.DataPropertyName = "Ramo";
            this.ramoDataGridViewTextBoxColumn.HeaderText = "Ramo";
            this.ramoDataGridViewTextBoxColumn.Name = "ramoDataGridViewTextBoxColumn";
            // 
            // anioDataGridViewTextBoxColumn
            // 
            this.anioDataGridViewTextBoxColumn.DataPropertyName = "Anio";
            this.anioDataGridViewTextBoxColumn.HeaderText = "Anio";
            this.anioDataGridViewTextBoxColumn.Name = "anioDataGridViewTextBoxColumn";
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            // 
            // vehiculoBindingSource
            // 
            this.vehiculoBindingSource.DataSource = typeof(Model.Vehiculo);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.SystemColors.Control;
            this.agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agregar.BackgroundImage")));
            this.agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.agregar.FlatAppearance.BorderSize = 0;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.ForeColor = System.Drawing.Color.Transparent;
            this.agregar.Location = new System.Drawing.Point(4, 6);
            this.agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(90, 60);
            this.agregar.TabIndex = 38;
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // borrar
            // 
            this.borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borrar.BackgroundImage")));
            this.borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.borrar.FlatAppearance.BorderSize = 0;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.ForeColor = System.Drawing.Color.Transparent;
            this.borrar.Location = new System.Drawing.Point(195, 6);
            this.borrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(90, 60);
            this.borrar.TabIndex = 41;
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // reinciar
            // 
            this.reinciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reinciar.BackgroundImage")));
            this.reinciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reinciar.FlatAppearance.BorderSize = 0;
            this.reinciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reinciar.ForeColor = System.Drawing.Color.Transparent;
            this.reinciar.Location = new System.Drawing.Point(292, 6);
            this.reinciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reinciar.Name = "reinciar";
            this.reinciar.Size = new System.Drawing.Size(90, 60);
            this.reinciar.TabIndex = 40;
            this.reinciar.UseVisualStyleBackColor = true;
            this.reinciar.Click += new System.EventHandler(this.reinciar_Click);
            // 
            // editar
            // 
            this.editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editar.BackgroundImage")));
            this.editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editar.FlatAppearance.BorderSize = 0;
            this.editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editar.ForeColor = System.Drawing.Color.Transparent;
            this.editar.Location = new System.Drawing.Point(100, 6);
            this.editar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(90, 60);
            this.editar.TabIndex = 42;
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // VehiculosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 320);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.reinciar);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VehiculosForm";
            this.Text = "Vehiculos";
            this.Load += new System.EventHandler(this.VehiculosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vehiculoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVersionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idRamoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ramoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button reinciar;
        private System.Windows.Forms.Button editar;
    }
}