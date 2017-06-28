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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.coberturasTipos = new System.Windows.Forms.ComboBox();
            this.coberturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.precio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.autoLabel = new System.Windows.Forms.Label();
            this.auto = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.prima = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.premio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cuotas = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label14 = new System.Windows.Forms.Label();
            this.reinciar = new System.Windows.Forms.Button();
            this.cotizar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.versionBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // marcas
            // 
            this.marcas.DataSource = this.marcaBindingSource;
            this.marcas.DisplayMember = "Nombre";
            this.marcas.FormattingEnabled = true;
            this.marcas.Location = new System.Drawing.Point(83, 26);
            this.marcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.marcas.Name = "marcas";
            this.marcas.Size = new System.Drawing.Size(156, 20);
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
            this.label1.Location = new System.Drawing.Point(34, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Marca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Modelo";
            // 
            // modelos
            // 
            this.modelos.DataSource = this.modeloBindingSource;
            this.modelos.DisplayMember = "Nombre";
            this.modelos.FormattingEnabled = true;
            this.modelos.Location = new System.Drawing.Point(407, 26);
            this.modelos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelos.Name = "modelos";
            this.modelos.Size = new System.Drawing.Size(262, 20);
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
            this.label3.Location = new System.Drawing.Point(720, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Version";
            // 
            // versiones
            // 
            this.versiones.DataSource = this.versionBindingSource;
            this.versiones.DisplayMember = "Nombre";
            this.versiones.FormattingEnabled = true;
            this.versiones.Location = new System.Drawing.Point(772, 26);
            this.versiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.versiones.Name = "versiones";
            this.versiones.Size = new System.Drawing.Size(264, 20);
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
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.marcas);
            this.groupBox1.Controls.Add(this.versiones);
            this.groupBox1.Controls.Add(this.modelos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(14, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1206, 60);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Vehiculo";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.groupBox2.Location = new System.Drawing.Point(15, 170);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1205, 122);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Persona";
            // 
            // localidadPersona
            // 
            this.localidadPersona.Enabled = false;
            this.localidadPersona.Location = new System.Drawing.Point(414, 86);
            this.localidadPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.localidadPersona.Name = "localidadPersona";
            this.localidadPersona.Size = new System.Drawing.Size(210, 20);
            this.localidadPersona.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "Localidad";
            // 
            // celularPersona
            // 
            this.celularPersona.Enabled = false;
            this.celularPersona.Location = new System.Drawing.Point(83, 86);
            this.celularPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.celularPersona.Name = "celularPersona";
            this.celularPersona.Size = new System.Drawing.Size(235, 20);
            this.celularPersona.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 12);
            this.label9.TabIndex = 9;
            this.label9.Text = "Celular";
            // 
            // cuilPersona
            // 
            this.cuilPersona.Enabled = false;
            this.cuilPersona.Location = new System.Drawing.Point(414, 60);
            this.cuilPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cuilPersona.Name = "cuilPersona";
            this.cuilPersona.Size = new System.Drawing.Size(210, 20);
            this.cuilPersona.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(379, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "Cuil";
            // 
            // emailPersona
            // 
            this.emailPersona.Enabled = false;
            this.emailPersona.Location = new System.Drawing.Point(83, 60);
            this.emailPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailPersona.Name = "emailPersona";
            this.emailPersona.Size = new System.Drawing.Size(235, 20);
            this.emailPersona.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(644, 24);
            this.buscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(89, 22);
            this.buscar.TabIndex = 4;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // apellidoPersona
            // 
            this.apellidoPersona.Location = new System.Drawing.Point(414, 26);
            this.apellidoPersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.apellidoPersona.Name = "apellidoPersona";
            this.apellidoPersona.Size = new System.Drawing.Size(210, 20);
            this.apellidoPersona.TabIndex = 3;
            // 
            // nombrePersona
            // 
            this.nombrePersona.Location = new System.Drawing.Point(83, 26);
            this.nombrePersona.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombrePersona.Name = "nombrePersona";
            this.nombrePersona.Size = new System.Drawing.Size(235, 20);
            this.nombrePersona.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(356, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nombre";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.coberturasTipos);
            this.groupBox4.Location = new System.Drawing.Point(15, 110);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(1205, 55);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cobertura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(35, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 7;
            this.label13.Text = "Tipos";
            // 
            // coberturasTipos
            // 
            this.coberturasTipos.DataSource = this.coberturaBindingSource;
            this.coberturasTipos.DisplayMember = "Nombre";
            this.coberturasTipos.FormattingEnabled = true;
            this.coberturasTipos.Location = new System.Drawing.Point(82, 24);
            this.coberturasTipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coberturasTipos.Name = "coberturasTipos";
            this.coberturasTipos.Size = new System.Drawing.Size(156, 20);
            this.coberturasTipos.TabIndex = 0;
            this.coberturasTipos.ValueMember = "IdCobertura";
            // 
            // coberturaBindingSource
            // 
            this.coberturaBindingSource.DataSource = typeof(Model.Cobertura);
            // 
            // precio
            // 
            this.precio.AutoSize = true;
            this.precio.BackColor = System.Drawing.SystemColors.Control;
            this.precio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.precio.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.precio.ForeColor = System.Drawing.Color.DodgerBlue;
            this.precio.Location = new System.Drawing.Point(348, 22);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(68, 18);
            this.precio.TabIndex = 18;
            this.precio.Text = "000000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Precio del 0km";
            // 
            // autoLabel
            // 
            this.autoLabel.AutoSize = true;
            this.autoLabel.BackColor = System.Drawing.SystemColors.Control;
            this.autoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.autoLabel.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel.ForeColor = System.Drawing.Color.DimGray;
            this.autoLabel.Location = new System.Drawing.Point(3, 0);
            this.autoLabel.Name = "autoLabel";
            this.autoLabel.Size = new System.Drawing.Size(142, 18);
            this.autoLabel.TabIndex = 19;
            this.autoLabel.Text = "Descripción Auto";
            // 
            // auto
            // 
            this.auto.AutoSize = true;
            this.auto.BackColor = System.Drawing.SystemColors.Control;
            this.auto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.auto.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.auto.ForeColor = System.Drawing.Color.DodgerBlue;
            this.auto.Location = new System.Drawing.Point(348, 0);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(243, 18);
            this.auto.TabIndex = 20;
            this.auto.Text = "VW-GOLF-GOLTRENDLINE 1.6";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label15.ForeColor = System.Drawing.Color.DimGray;
            this.label15.Location = new System.Drawing.Point(3, 44);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 18);
            this.label15.TabIndex = 21;
            this.label15.Text = "Prima";
            // 
            // prima
            // 
            this.prima.AutoSize = true;
            this.prima.BackColor = System.Drawing.SystemColors.Control;
            this.prima.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prima.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.prima.ForeColor = System.Drawing.Color.DodgerBlue;
            this.prima.Location = new System.Drawing.Point(348, 44);
            this.prima.Name = "prima";
            this.prima.Size = new System.Drawing.Size(68, 18);
            this.prima.TabIndex = 22;
            this.prima.Text = "000000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(3, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Premio";
            // 
            // premio
            // 
            this.premio.AutoSize = true;
            this.premio.BackColor = System.Drawing.SystemColors.Control;
            this.premio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.premio.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.premio.ForeColor = System.Drawing.Color.DodgerBlue;
            this.premio.Location = new System.Drawing.Point(348, 66);
            this.premio.Name = "premio";
            this.premio.Size = new System.Drawing.Size(68, 18);
            this.premio.TabIndex = 24;
            this.premio.Text = "000000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(3, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 18);
            this.label12.TabIndex = 25;
            this.label12.Text = "6 Cuotas";
            // 
            // cuotas
            // 
            this.cuotas.AutoSize = true;
            this.cuotas.BackColor = System.Drawing.SystemColors.Control;
            this.cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotas.Font = new System.Drawing.Font("Lucida Sans", 12F);
            this.cuotas.ForeColor = System.Drawing.Color.DodgerBlue;
            this.cuotas.Location = new System.Drawing.Point(348, 88);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(68, 18);
            this.cuotas.TabIndex = 26;
            this.cuotas.Text = "000000";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.65014F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.34986F));
            this.tableLayoutPanel1.Controls.Add(this.autoLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cuotas, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.premio, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.prima, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.precio, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.auto, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 3);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Lucida Sans", 8.25F);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 341);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1205, 108);
            this.tableLayoutPanel1.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.OliveDrab;
            this.label14.Location = new System.Drawing.Point(14, 299);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(205, 24);
            this.label14.TabIndex = 28;
            this.label14.Text = "Detalle de la Cotización";
            // 
            // reinciar
            // 
            this.reinciar.Location = new System.Drawing.Point(108, 11);
            this.reinciar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reinciar.Name = "reinciar";
            this.reinciar.Size = new System.Drawing.Size(91, 26);
            this.reinciar.TabIndex = 30;
            this.reinciar.Text = "Reiniciar";
            this.reinciar.UseVisualStyleBackColor = true;
            this.reinciar.Click += new System.EventHandler(this.reinciar_Click);
            // 
            // cotizar
            // 
            this.cotizar.Enabled = false;
            this.cotizar.Location = new System.Drawing.Point(14, 11);
            this.cotizar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cotizar.Name = "cotizar";
            this.cotizar.Size = new System.Drawing.Size(91, 26);
            this.cotizar.TabIndex = 29;
            this.cotizar.Text = "Cotizar";
            this.cotizar.UseVisualStyleBackColor = true;
            this.cotizar.Click += new System.EventHandler(this.cotizar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Location = new System.Drawing.Point(16, 326);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(1206, 2);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // CotizadorVehiculoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 472);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.reinciar);
            this.Controls.Add(this.cotizar);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coberturaBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox coberturasTipos;
        private System.Windows.Forms.BindingSource coberturaBindingSource;
        private System.Windows.Forms.Label precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label autoLabel;
        private System.Windows.Forms.Label auto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label prima;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label premio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label cuotas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button reinciar;
        private System.Windows.Forms.Button cotizar;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}