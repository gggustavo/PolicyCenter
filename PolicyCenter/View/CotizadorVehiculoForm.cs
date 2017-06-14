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
    public partial class CotizadorVehiculoForm : Form
    {
        private Controller.MarcasController marcasController = new Controller.MarcasController();
        private Controller.ModelosController modelosController = new Controller.ModelosController();        

        public CotizadorVehiculoForm()
        {
            InitializeComponent();

            marcaBindingSource.DataSource = marcasController.ObtenerMarcas();
            marcas.SelectedIndex = -1;
        }

        private void marcas_SelectionChangeCommitted(object sender, EventArgs e)
        {           
            var idMarca = ((Model.Marca)marcaBindingSource.Current).IdMarca;
            modeloBindingSource.DataSource = modelosController.ObtenerModelos().Where(_ => _.IdMarca == idMarca);
            modelos.SelectedIndex = -1;
        }

       
    }
}
