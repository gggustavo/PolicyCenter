namespace View
{
    partial class CarteraPolizasForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPolizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCoberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coberturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.identificadorPolizaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigenciaDesdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vigenciaHastaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.polizaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.crear = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Location = new System.Drawing.Point(12, 78);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox5.Size = new System.Drawing.Size(1206, 2);
            this.groupBox5.TabIndex = 36;
            this.groupBox5.TabStop = false;
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
            this.idPolizaDataGridViewTextBoxColumn,
            this.guidDataGridViewTextBoxColumn,
            this.idProductorDataGridViewTextBoxColumn,
            this.productorDataGridViewTextBoxColumn,
            this.idPersonaDataGridViewTextBoxColumn,
            this.personaDataGridViewTextBoxColumn,
            this.idBienDataGridViewTextBoxColumn,
            this.bienDataGridViewTextBoxColumn,
            this.idCoberturaDataGridViewTextBoxColumn,
            this.coberturaDataGridViewTextBoxColumn,
            this.identificadorPolizaDataGridViewTextBoxColumn,
            this.vigenciaDesdeDataGridViewTextBoxColumn,
            this.vigenciaHastaDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.primaDataGridViewTextBoxColumn,
            this.premioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.polizaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1239, 470);
            this.dataGridView1.TabIndex = 37;
            // 
            // idPolizaDataGridViewTextBoxColumn
            // 
            this.idPolizaDataGridViewTextBoxColumn.DataPropertyName = "IdPoliza";
            this.idPolizaDataGridViewTextBoxColumn.HeaderText = "IdPoliza";
            this.idPolizaDataGridViewTextBoxColumn.Name = "idPolizaDataGridViewTextBoxColumn";
            this.idPolizaDataGridViewTextBoxColumn.Visible = false;
            // 
            // guidDataGridViewTextBoxColumn
            // 
            this.guidDataGridViewTextBoxColumn.DataPropertyName = "Guid";
            this.guidDataGridViewTextBoxColumn.HeaderText = "Guid";
            this.guidDataGridViewTextBoxColumn.Name = "guidDataGridViewTextBoxColumn";
            this.guidDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProductorDataGridViewTextBoxColumn
            // 
            this.idProductorDataGridViewTextBoxColumn.DataPropertyName = "IdProductor";
            this.idProductorDataGridViewTextBoxColumn.HeaderText = "IdProductor";
            this.idProductorDataGridViewTextBoxColumn.Name = "idProductorDataGridViewTextBoxColumn";
            this.idProductorDataGridViewTextBoxColumn.Visible = false;
            // 
            // productorDataGridViewTextBoxColumn
            // 
            this.productorDataGridViewTextBoxColumn.DataPropertyName = "Productor";
            this.productorDataGridViewTextBoxColumn.HeaderText = "Productor";
            this.productorDataGridViewTextBoxColumn.Name = "productorDataGridViewTextBoxColumn";
            this.productorDataGridViewTextBoxColumn.Width = 150;
            // 
            // idPersonaDataGridViewTextBoxColumn
            // 
            this.idPersonaDataGridViewTextBoxColumn.DataPropertyName = "IdPersona";
            this.idPersonaDataGridViewTextBoxColumn.HeaderText = "IdPersona";
            this.idPersonaDataGridViewTextBoxColumn.Name = "idPersonaDataGridViewTextBoxColumn";
            this.idPersonaDataGridViewTextBoxColumn.Visible = false;
            // 
            // personaDataGridViewTextBoxColumn
            // 
            this.personaDataGridViewTextBoxColumn.DataPropertyName = "Persona";
            this.personaDataGridViewTextBoxColumn.HeaderText = "Persona";
            this.personaDataGridViewTextBoxColumn.Name = "personaDataGridViewTextBoxColumn";
            this.personaDataGridViewTextBoxColumn.Width = 200;
            // 
            // idBienDataGridViewTextBoxColumn
            // 
            this.idBienDataGridViewTextBoxColumn.DataPropertyName = "IdBien";
            this.idBienDataGridViewTextBoxColumn.HeaderText = "IdBien";
            this.idBienDataGridViewTextBoxColumn.Name = "idBienDataGridViewTextBoxColumn";
            this.idBienDataGridViewTextBoxColumn.Visible = false;
            // 
            // bienDataGridViewTextBoxColumn
            // 
            this.bienDataGridViewTextBoxColumn.DataPropertyName = "Bien";
            this.bienDataGridViewTextBoxColumn.HeaderText = "Bien";
            this.bienDataGridViewTextBoxColumn.Name = "bienDataGridViewTextBoxColumn";
            this.bienDataGridViewTextBoxColumn.Width = 250;
            // 
            // idCoberturaDataGridViewTextBoxColumn
            // 
            this.idCoberturaDataGridViewTextBoxColumn.DataPropertyName = "IdCobertura";
            this.idCoberturaDataGridViewTextBoxColumn.HeaderText = "IdCobertura";
            this.idCoberturaDataGridViewTextBoxColumn.Name = "idCoberturaDataGridViewTextBoxColumn";
            this.idCoberturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // coberturaDataGridViewTextBoxColumn
            // 
            this.coberturaDataGridViewTextBoxColumn.DataPropertyName = "Cobertura";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.coberturaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.coberturaDataGridViewTextBoxColumn.HeaderText = "Cobertura";
            this.coberturaDataGridViewTextBoxColumn.Name = "coberturaDataGridViewTextBoxColumn";
            this.coberturaDataGridViewTextBoxColumn.Width = 80;
            // 
            // identificadorPolizaDataGridViewTextBoxColumn
            // 
            this.identificadorPolizaDataGridViewTextBoxColumn.DataPropertyName = "IdentificadorPoliza";
            this.identificadorPolizaDataGridViewTextBoxColumn.HeaderText = "IdentificadorPoliza";
            this.identificadorPolizaDataGridViewTextBoxColumn.Name = "identificadorPolizaDataGridViewTextBoxColumn";
            this.identificadorPolizaDataGridViewTextBoxColumn.Width = 200;
            // 
            // vigenciaDesdeDataGridViewTextBoxColumn
            // 
            this.vigenciaDesdeDataGridViewTextBoxColumn.DataPropertyName = "VigenciaDesde";
            this.vigenciaDesdeDataGridViewTextBoxColumn.HeaderText = "VigenciaDesde";
            this.vigenciaDesdeDataGridViewTextBoxColumn.Name = "vigenciaDesdeDataGridViewTextBoxColumn";
            this.vigenciaDesdeDataGridViewTextBoxColumn.Width = 120;
            // 
            // vigenciaHastaDataGridViewTextBoxColumn
            // 
            this.vigenciaHastaDataGridViewTextBoxColumn.DataPropertyName = "VigenciaHasta";
            this.vigenciaHastaDataGridViewTextBoxColumn.HeaderText = "VigenciaHasta";
            this.vigenciaHastaDataGridViewTextBoxColumn.Name = "vigenciaHastaDataGridViewTextBoxColumn";
            this.vigenciaHastaDataGridViewTextBoxColumn.Width = 120;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "Estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            // 
            // primaDataGridViewTextBoxColumn
            // 
            this.primaDataGridViewTextBoxColumn.DataPropertyName = "Prima";
            this.primaDataGridViewTextBoxColumn.HeaderText = "Prima";
            this.primaDataGridViewTextBoxColumn.Name = "primaDataGridViewTextBoxColumn";
            this.primaDataGridViewTextBoxColumn.Visible = false;
            // 
            // premioDataGridViewTextBoxColumn
            // 
            this.premioDataGridViewTextBoxColumn.DataPropertyName = "Premio";
            this.premioDataGridViewTextBoxColumn.HeaderText = "Premio";
            this.premioDataGridViewTextBoxColumn.Name = "premioDataGridViewTextBoxColumn";
            this.premioDataGridViewTextBoxColumn.Visible = false;
            // 
            // polizaBindingSource
            // 
            this.polizaBindingSource.DataSource = typeof(Model.Poliza);
            // 
            // crear
            // 
            this.crear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.crear.FlatAppearance.BorderSize = 0;
            this.crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crear.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.ForeColor = System.Drawing.Color.Black;
            this.crear.Location = new System.Drawing.Point(12, 11);
            this.crear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(90, 60);
            this.crear.TabIndex = 38;
            this.crear.Text = "Crear";
            this.crear.UseVisualStyleBackColor = true;
            this.crear.Click += new System.EventHandler(this.crear_Click);
            // 
            // actualizar
            // 
            this.actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.actualizar.FlatAppearance.BorderSize = 0;
            this.actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualizar.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar.ForeColor = System.Drawing.Color.Black;
            this.actualizar.Location = new System.Drawing.Point(108, 11);
            this.actualizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(90, 60);
            this.actualizar.TabIndex = 39;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.actualizar_Click);
            // 
            // CarteraPolizasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 555);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.crear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox5);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CarteraPolizasForm";
            this.ShowInTaskbar = false;
            this.Text = "Poliza Vehiculo";
            this.Load += new System.EventHandler(this.CarteraPolizasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.polizaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource polizaBindingSource;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPolizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersonaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCoberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coberturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificadorPolizaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigenciaDesdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vigenciaHastaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn premioDataGridViewTextBoxColumn;
    }
}