namespace View
{
    partial class PersonasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonasForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDireccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idLocalidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reinciar = new System.Windows.Forms.Button();
            this.agregar = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
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
            this.idPersonaDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.cuitDataGridViewTextBoxColumn,
            this.cuilDataGridViewTextBoxColumn,
            this.edadDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.idDireccionDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.idLocalidadDataGridViewTextBoxColumn,
            this.localidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1126, 240);
            this.dataGridView1.TabIndex = 0;
            // 
            // idPersonaDataGridViewTextBoxColumn
            // 
            this.idPersonaDataGridViewTextBoxColumn.DataPropertyName = "IdPersona";
            this.idPersonaDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idPersonaDataGridViewTextBoxColumn.Name = "idPersonaDataGridViewTextBoxColumn";
            this.idPersonaDataGridViewTextBoxColumn.Visible = false;
            this.idPersonaDataGridViewTextBoxColumn.Width = 80;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // cuitDataGridViewTextBoxColumn
            // 
            this.cuitDataGridViewTextBoxColumn.DataPropertyName = "Cuit";
            this.cuitDataGridViewTextBoxColumn.HeaderText = "Cuit";
            this.cuitDataGridViewTextBoxColumn.Name = "cuitDataGridViewTextBoxColumn";
            // 
            // cuilDataGridViewTextBoxColumn
            // 
            this.cuilDataGridViewTextBoxColumn.DataPropertyName = "Cuil";
            this.cuilDataGridViewTextBoxColumn.HeaderText = "Cuil";
            this.cuilDataGridViewTextBoxColumn.Name = "cuilDataGridViewTextBoxColumn";
            // 
            // edadDataGridViewTextBoxColumn
            // 
            this.edadDataGridViewTextBoxColumn.DataPropertyName = "Edad";
            this.edadDataGridViewTextBoxColumn.HeaderText = "Edad";
            this.edadDataGridViewTextBoxColumn.Name = "edadDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            // 
            // idDireccionDataGridViewTextBoxColumn
            // 
            this.idDireccionDataGridViewTextBoxColumn.DataPropertyName = "IdDireccion";
            this.idDireccionDataGridViewTextBoxColumn.HeaderText = "IdDireccion";
            this.idDireccionDataGridViewTextBoxColumn.Name = "idDireccionDataGridViewTextBoxColumn";
            this.idDireccionDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            // 
            // idLocalidadDataGridViewTextBoxColumn
            // 
            this.idLocalidadDataGridViewTextBoxColumn.DataPropertyName = "IdLocalidad";
            this.idLocalidadDataGridViewTextBoxColumn.HeaderText = "IdLocalidad";
            this.idLocalidadDataGridViewTextBoxColumn.Name = "idLocalidadDataGridViewTextBoxColumn";
            this.idLocalidadDataGridViewTextBoxColumn.Visible = false;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            this.localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            this.localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            this.localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Model.Persona);
            // 
            // reinciar
            // 
            this.reinciar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reinciar.BackgroundImage")));
            this.reinciar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reinciar.FlatAppearance.BorderSize = 0;
            this.reinciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reinciar.ForeColor = System.Drawing.Color.Transparent;
            this.reinciar.Location = new System.Drawing.Point(204, 11);
            this.reinciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reinciar.Name = "reinciar";
            this.reinciar.Size = new System.Drawing.Size(90, 60);
            this.reinciar.TabIndex = 36;
            this.reinciar.UseVisualStyleBackColor = true;
            this.reinciar.Click += new System.EventHandler(this.reinciar_Click);
            // 
            // agregar
            // 
            this.agregar.BackColor = System.Drawing.SystemColors.Control;
            this.agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("agregar.BackgroundImage")));
            this.agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.agregar.FlatAppearance.BorderSize = 0;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.ForeColor = System.Drawing.Color.Transparent;
            this.agregar.Location = new System.Drawing.Point(12, 11);
            this.agregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(90, 60);
            this.agregar.TabIndex = 37;
            this.agregar.UseVisualStyleBackColor = false;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Location = new System.Drawing.Point(-40, 82);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1206, 2);
            this.groupBox5.TabIndex = 38;
            this.groupBox5.TabStop = false;
            // 
            // borrar
            // 
            this.borrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("borrar.BackgroundImage")));
            this.borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.borrar.FlatAppearance.BorderSize = 0;
            this.borrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borrar.ForeColor = System.Drawing.Color.Transparent;
            this.borrar.Location = new System.Drawing.Point(108, 11);
            this.borrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(90, 60);
            this.borrar.TabIndex = 39;
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // PersonasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 329);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.agregar);
            this.Controls.Add(this.reinciar);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PersonasForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.Button reinciar;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDireccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLocalidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button borrar;
    }
}