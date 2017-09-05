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


        public VehiculoAddForm()
        {
            InitializeComponent();

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

            var bien = new Model.Vehiculo
            {
                IdMarca = ((Model.Marca)marcaBindingSource.Current).IdMarca,
                IdModelo = ((Model.Modelo)modeloBindingSource.Current).IdModelo,
                IdVersion =  ((Model.Version)versionBindingSource.Current).IdVersion,
                Precio = Convert.ToDecimal(precio.Text),
                Anio = Convert.ToInt32(anio.Text),
                IdRamo = ((Model.Ramo)ramoBindingSource.Current).IdRamo,
                Activo = true
            };

            vehiculoController.AgregarVehiculo(bien);
            Close();

        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        

        
    }
}
