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
    public partial class VehiculoAddForm : Form
    {
        private Controller.MarcasController marcasController;
        private Controller.ModelosController modelosController;
        

        public VehiculoAddForm()
        {
            InitializeComponent();

            marcasController = new Controller.MarcasController();
            modelosController = new Controller.ModelosController();

            marcaBindingSource.DataSource = marcasController.ObtenerMarcas();
            modeloBindingSource.DataSource = modelosController.ObtenerModelos();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
           
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        
    }
}
