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
    public partial class CoberturasForm : Form
    {

        private Controller.CoberturasController coberturasController = new Controller.CoberturasController();

        public CoberturasForm()
        {
            InitializeComponent();
            
            coberturaBindingSource.DataSource = coberturasController.ObtenerCoberturas();
        }
    }
}
