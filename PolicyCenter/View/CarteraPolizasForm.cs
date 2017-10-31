using Rule;
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
    public partial class CarteraPolizasForm : Form
    {
        private Controller.CarteraPolizaController carteraPolizaController = new Controller.CarteraPolizaController();
        private Controller.VehiculosController vehiculoController = new Controller.VehiculosController();

        public CarteraPolizasForm()
        {
            InitializeComponent();

            CargarPolizas();
        }

        private void CargarPolizas()
        {
            polizaBindingSource.DataSource = carteraPolizaController.ObtenerPolizas()
                .Select(_ => new
                {
                    Bien = ObtenerVehiculo(_.IdBien),
                    Productor = _.Productor.Nombre,
                    Persona = _.Persona.Nombre,
                    Cobertura = _.Cobertura.Nombre,
                    IdentificadorPoliza = _.IdentificadorPoliza,
                    VigenciaDesde = _.VigenciaDesde,
                    VigenciaHasta = _.VigenciaHasta,
                    Estado = _.Estado
                });
        }

        private string ObtenerVehiculo(int idBien)
        {
            var vehiculo = vehiculoController.ObtenerVehiculo(idBien);
            return vehiculo.Modelo.Nombre + " - " + vehiculo.Version.Nombre;
        }

        private void crear_Click(object sender, EventArgs e)
        {
            var cotizador = new CotizadorEmisionVehiculoForm();
            cotizador.ShowDialog();
            CargarPolizas();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            CargarPolizas();
        }

        private void CarteraPolizasForm_Load(object sender, EventArgs e)
        {

        }

    }
}
