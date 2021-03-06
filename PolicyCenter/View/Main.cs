﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();            

            MdiClient ctlMDI;
            foreach (Control ctl in this.Controls)
            {
                try
                {                    
                    ctlMDI = (MdiClient)ctl;                    
                    ctlMDI.BackColor = Color.GhostWhite;
                }
                catch (InvalidCastException)
                {                 
                }
            }
        }
       
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new MarcasForm());
        }

        private void modelosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ModelosForm());
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new LocalidadesForm());
        }

        private void organizadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new OrganizadoresForm());
        }

        private void productoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new ProductoresForm());
        }

        private void ShowForm(Form form)
        {
            form.MdiParent = this;
            form.ShowInTaskbar = false;
            form.ShowIcon = false;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new PersonasForm());
        }

        private void coberturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new CoberturasForm());
        }

        private void ramosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new RamosForm());
        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new VehiculosForm());
        }

        private void autosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowForm(new CotizadorEmisionVehiculoForm());
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ubicacionRiesgoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Rule.UbicacionRiesgoForm());
        }

        private void antiguedadRiesgoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new Rule.AntiguedadRiesgoForm());
        }

        private void polizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm(new CarteraPolizasForm());
        }
 
    }
}
