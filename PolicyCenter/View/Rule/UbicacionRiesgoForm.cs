using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Rule
{
    public partial class UbicacionRiesgoForm : Form
    {
        private Controller.UbicacionRiesgoController ubicacionController;

        public UbicacionRiesgoForm()
        {
            InitializeComponent();
        }

        private void UbicacionRiesgoForm_Load(object sender, EventArgs e)
        {
            ubicacionController = new Controller.UbicacionRiesgoController();
            ubicacionRiesgoBindingSource.DataSource = ubicacionController.ObtenerUbicacionRiesgo();
        }

        
    }
}
