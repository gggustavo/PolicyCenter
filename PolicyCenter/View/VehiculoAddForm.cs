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
        private Controller.VersionesController versionController;
        private Controller.RamosController ramoController;
        private Controller.VehiculosController vehiculoController;
        private Model.Vehiculo vehiculoEdit = null;

        public VehiculoAddForm(int idBien)
        {
            InitializeComponent();

            Initialize();
            vehiculoEdit = vehiculoController.ObtenerVehiculo(idBien);
            marcas.SelectedValue = vehiculoEdit.Marca.IdMarca;
            modelos.SelectedValue = vehiculoEdit.Modelo.IdModelo;
            versiones.SelectedValue = vehiculoEdit.Version.IdVersion;
            anio.Text = vehiculoEdit.Anio.ToString();
            ramo.SelectedValue = vehiculoEdit.IdRamo;

            marcas.Enabled = false;
            modelos.Enabled = false;
            versiones.Enabled = false;
            anio.Enabled = false;
            ramo.Enabled = false;

            precio.Text = vehiculoEdit.Precio.ToString();

        }
        public VehiculoAddForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            marcasController = new Controller.MarcasController();
            modelosController = new Controller.ModelosController();
            versionController = new Controller.VersionesController();
            ramoController = new Controller.RamosController();
            vehiculoController = new Controller.VehiculosController();

            marcaBindingSource.DataSource = marcasController.ObtenerMarcas();
            modeloBindingSource.DataSource = modelosController.ObtenerModelos();
            versionBindingSource.DataSource = versionController.ObtenerVersiones();
            ramoBindingSource.DataSource = ramoController.ObtenerRamos();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(precio.Text)) { MessageBox.Show("Ingrese un precio"); return; }
            if (string.IsNullOrEmpty(anio.Text)) { MessageBox.Show("Ingrese un año"); return; }

            if (marcaBindingSource.Current == null) { MessageBox.Show("Seleccione una Marca"); return; }
            if (modeloBindingSource.Current == null) { MessageBox.Show("Seleccione un Modelo"); return; }
            if (versionBindingSource.Current == null) { MessageBox.Show("Seleccione una Version"); return; }

            if (vehiculoEdit == null)
            {
                var bien = new Model.Vehiculo
                {
                    IdMarca = ((Model.Marca)marcaBindingSource.Current).IdMarca,
                    IdModelo = ((Model.Modelo)modeloBindingSource.Current).IdModelo,
                    IdVersion = ((Model.Version)versionBindingSource.Current).IdVersion,
                    Precio = Convert.ToDecimal(precio.Text),
                    Anio = Convert.ToInt32(anio.Text),
                    IdRamo = ((Model.Ramo)ramoBindingSource.Current).IdRamo,
                    Activo = true
                };

                vehiculoController.AgregarVehiculo(bien);
            }
            else
            {
                vehiculoEdit.Precio = Convert.ToDecimal(precio.Text);
                vehiculoController.ModificarVehiculo(vehiculoEdit);
            }
           
            Close();

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void marcas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idMarca = ((Model.Marca)(((ComboBox)(sender)).SelectedItem)).IdMarca;
            var result = modelosController.ObtenerModelos().Where(_ => _.IdMarca == idMarca);
            modeloBindingSource.DataSource = result;
            if (!result.Any()) modeloBindingSource.DataSource = null;
            modelos.SelectedIndex = -1;
            versionBindingSource.DataSource = null;
            versiones.SelectedIndex = -1;
        }


        private void modelos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var idModelo = ((Model.Modelo)(((ComboBox)(sender)).SelectedItem)).IdModelo;
            versionBindingSource.DataSource = versionController.ObtenerVersiones().Where(s => s.Models.Any(_ => _.IdModelo == idModelo));
            versiones.SelectedIndex = -1;
        }



      
        

        
    }
}
