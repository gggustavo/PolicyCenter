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
    public partial class VehiculosForm : Form
    {
        private Controller.VehiculosController vehiculosController = new Controller.VehiculosController();

        public VehiculosForm()
        {
            InitializeComponent();

            GetData();
        }

        private void GetData()
        {
            vehiculoBindingSource.DataSource = vehiculosController.ObtenerVehiculos()
                                                                  .Select(_ => new
                                                                  {
                                                                      IdBien = _.IdBien,
                                                                      Marca = _.Marca.Nombre,
                                                                      Modelo = _.Modelo.Nombre,
                                                                      Version = _.Version.Nombre,
                                                                      Precio = _.Precio,
                                                                      Ramo = _.Ramo.Nombre,
                                                                      Anio = _.Anio
                                                                  });
        }

        private void VehiculosForm_Load(object sender, EventArgs e)
        {

        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (vehiculoBindingSource.Current == null) MessageBox.Show("Seleccione un vehiculo");

            dynamic current = vehiculoBindingSource.Current;
            var idBien = current.IdBien;

            vehiculosController.Eliminar(idBien);
        }

        private void reinciar_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private void agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
