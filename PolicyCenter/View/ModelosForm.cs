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
    public partial class ModelosForm : Form
    {
        private Controller.ModelosController modelosController;

        public ModelosForm()
        {
            InitializeComponent();

            modelosController = new Controller.ModelosController();

            modeloBindingSource.DataSource = modelosController.ObtenerModelos();
        }
    }
}
