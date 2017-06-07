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
    public partial class ProductoresForm : Form
    {
        private Controller.ProductoresController productoresController;

        public ProductoresForm()
        {
            InitializeComponent();
            productoresController = new Controller.ProductoresController();

            productorBindingSource.DataSource = productoresController.ObtenerProductores();
        }
    }
}
