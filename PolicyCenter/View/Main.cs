using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void treeViewLeft_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text == "Marcas")
            {
                var marcas = new MarcasForm();
                marcas.TopLevel = false;
                marcas.ShowInTaskbar = false;
                marcas.Visible = true;
                marcas.WindowState = FormWindowState.Maximized;
                marcas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                splitContainer1.Panel2.Controls.Add(marcas);
            }
            else
            {
                splitContainer1.Panel2.Controls.Clear();
            }
        }

        private void splitContainer1_Panel1_ClientSizeChanged(object sender, EventArgs e)
        {
            var control = (SplitterPanel)(sender);
            
            if (control.Width == splitContainer1.Panel1MinSize)
            {
                splitContainer1.Panel1Collapsed = true;
                showLeft.Text = ">>";
            }
        }

        
        private void showLeft_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                splitContainer1.SplitterDistance = 100;
                splitContainer1.Panel1Collapsed = false;  
                showLeft.Text = "<<";
            }
            else
            {
                splitContainer1.Panel1Collapsed = true;  
                showLeft.Text = ">>";
            }
        }

 
    }
}
