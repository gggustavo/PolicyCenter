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
    public partial class AntiguedadRiesgoForm : Form
    {
        private Controller.AntiguedadRiesgoController antiguedadRiesgoController;

        public AntiguedadRiesgoForm()
        {
            InitializeComponent();
        }

        private void UbicacionRiesgoForm_Load(object sender, EventArgs e)
        {
            antiguedadRiesgoController = new Controller.AntiguedadRiesgoController();
            antiguedadRiesgoBindingSource.DataSource = antiguedadRiesgoController.ObtenerAntiguedadRiesgo();
        }

        
    }
}
