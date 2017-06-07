using System;
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
            Controller.Test.Initialize();

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
            form.WindowState = FormWindowState.Maximized;
            form.ShowInTaskbar = false;
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
 
    }
}
