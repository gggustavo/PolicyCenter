namespace View
{
    partial class OrganizadoresForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.organizadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idOrganizadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizadorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOrganizadorDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.idProductorDataGridViewTextBoxColumn,
            this.productoresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.organizadorBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(552, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // organizadorBindingSource
            // 
            this.organizadorBindingSource.DataSource = typeof(Model.Organizador);
            // 
            // idOrganizadorDataGridViewTextBoxColumn
            // 
            this.idOrganizadorDataGridViewTextBoxColumn.DataPropertyName = "IdOrganizador";
            this.idOrganizadorDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idOrganizadorDataGridViewTextBoxColumn.Name = "idOrganizadorDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 350;
            // 
            // idProductorDataGridViewTextBoxColumn
            // 
            this.idProductorDataGridViewTextBoxColumn.DataPropertyName = "IdProductor";
            this.idProductorDataGridViewTextBoxColumn.HeaderText = "IdProductor";
            this.idProductorDataGridViewTextBoxColumn.Name = "idProductorDataGridViewTextBoxColumn";
            this.idProductorDataGridViewTextBoxColumn.Visible = false;
            // 
            // productoresDataGridViewTextBoxColumn
            // 
            this.productoresDataGridViewTextBoxColumn.DataPropertyName = "Productores";
            this.productoresDataGridViewTextBoxColumn.HeaderText = "Productores";
            this.productoresDataGridViewTextBoxColumn.Name = "productoresDataGridViewTextBoxColumn";
            this.productoresDataGridViewTextBoxColumn.Visible = false;
            // 
            // OrganizadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 261);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "OrganizadoresForm";
            this.Text = "Organizadores";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizadorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOrganizadorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productoresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource organizadorBindingSource;
    }
}