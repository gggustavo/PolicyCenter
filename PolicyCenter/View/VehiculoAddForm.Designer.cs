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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.localidades = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.confirmar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.localidades, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(59, 95);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(482, 58);
            this.tableLayoutPanel1.TabIndex = 0;
           
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(4, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 27);
            this.label10.TabIndex = 18;
            this.label10.Text = "Marca";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // localidades
            // 
            this.localidades.DataSource = this.marcaBindingSource;
            this.localidades.DisplayMember = "Nombre";
            this.localidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.localidades.FormattingEnabled = true;
            this.localidades.Location = new System.Drawing.Point(55, 4);
            this.localidades.Name = "localidades";
            this.localidades.Size = new System.Drawing.Size(423, 20);
            this.localidades.TabIndex = 19;
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataSource = typeof(Model.Marca);
            // 
            // confirmar
            // 
            this.confirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmar.BackgroundImage")));
            this.confirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.confirmar.FlatAppearance.BorderSize = 0;
            this.confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmar.ForeColor = System.Drawing.Color.Transparent;
            this.confirmar.Location = new System.Drawing.Point(186, 369);
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
            this.cancelar.Location = new System.Drawing.Point(298, 368);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(95, 48);
            this.cancelar.TabIndex = 2;
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(236, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 77);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(4, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 28);
            this.label1.TabIndex = 20;
            this.label1.Text = "Modelo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.modeloBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(423, 20);
            this.comboBox1.TabIndex = 21;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataSource = typeof(Model.Modelo);
            // 
            // VehiculoAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(591, 445);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.confirmar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VehiculoAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonasAddForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox localidades;
        private System.Windows.Forms.Button confirmar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource modeloBindingSource;
    }
}