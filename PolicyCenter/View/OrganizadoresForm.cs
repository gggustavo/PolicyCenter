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
    public partial class OrganizadoresForm : Form
    {
        private Controller.OrganizadoresController organizadoresController;

        public OrganizadoresForm()
        {
            InitializeComponent();
            organizadoresController = new Controller.OrganizadoresController();

            organizadorBindingSource.DataSource = organizadoresController.ObtenerOrganizadores();
        }
    }
}
