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
    public partial class CotizadorVehiculoForm : Form
    {
        private Controller.MarcasController marcasController = new Controller.MarcasController();
        private Controller.ModelosController modelosController = new Controller.ModelosController();
        private Controller.VersionesController versionesController = new Controller.VersionesController();
        private Controller.VehiculosController vehiculosController = new Controller.VehiculosController();
        private Controller.PersonasController personasController = new Controller.PersonasController();
        private Controller.CoberturasController coberturasController = new Controller.CoberturasController();

        private Model.Vehiculo vehiculoSelect;
        private Model.Persona personaSelect;


        public CotizadorVehiculoForm()
        {
            InitializeComponent();

            marcaBindingSource.DataSource = marcasController.ObtenerMarcas();            
            coberturaBindingSource.DataSource = coberturasController.ObtenerCoberturas();

            Reset();
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
            versionBindingSource.DataSource = versionesController.ObtenerVersiones().Where(s => s.Models.Any(_ => _.IdModelo == idModelo));
            versiones.SelectedIndex = -1;
        }

        private void versiones_SelectionChangeCommitted(object sender, EventArgs e)
        {
            precio.Text = string.Empty;
            var idMarca = ((Model.Marca)marcaBindingSource.Current).IdMarca;
            var idModelo = ((Model.Modelo)modeloBindingSource.Current).IdModelo;
            var idVersion = ((Model.Version)(((ComboBox)(sender)).SelectedItem)).IdVersion;

            var vehiculo = vehiculosController.ObtenerVehiculos()
                                              .Where(_ => _.IdMarca == idMarca && _.IdModelo == idModelo && _.IdVersion == idVersion)
                                              .FirstOrDefault();

            vehiculoSelect = vehiculo;

            if (vehiculo == null) { MessageBox.Show("Precio No Disponible"); return; }
            precio.Text = string.Format("{0:000,000.## $}", vehiculo.Precio);
            auto.Text = vehiculo.Marca.Nombre + "-" + vehiculo.Modelo.Nombre + "-" + vehiculo.Version.Nombre;
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nombrePersona.Text)) { MessageBox.Show("Ingrese un nombre"); return; }
            if (string.IsNullOrEmpty(apellidoPersona.Text)) { MessageBox.Show("Ingrese un apellido"); return; } 


            var persona = personasController.ObtenerPersonas().Where(_ => _.Nombre.ToUpper() == nombrePersona.Text.ToUpper() &&
                                                             _.Apellido.ToUpper() == apellidoPersona.Text.ToUpper()).FirstOrDefault();


            if (persona == null) { MessageBox.Show("Persona no encontrada!"); return; };

            personaSelect = persona;
            emailPersona.Text = persona.Email;
            cuilPersona.Text = persona.Cuil;
            celularPersona.Text = persona.Celular;
            localidadPersona.Text = persona.Localidad.Nombre;
            cotizar.Enabled = true;

        }

        private void cotizar_Click(object sender, EventArgs e)
        {
            var idCobertura = ((Model.Cobertura)coberturaBindingSource.Current).IdCobertura;
            var poliza = new Model.Poliza
            {
                IdPersona = personaSelect.IdPersona,
                Persona = personaSelect,
                IdProductor = 1,
                IdBien = vehiculoSelect.IdBien,
                Bien = vehiculoSelect,
                IdCobertura = idCobertura,
                VigenciaDesde = System.DateTime.Now,
                VigenciaHasta = System.DateTime.Now.AddDays(180),
                Estado = "Vigente"
            };

            var rules = new ReglasPoliza(poliza);
            poliza.Prima = rules.CalcularPrima();

            prima.Text = string.Format("{0:###,000.## $}", poliza.Prima);

            poliza.Premio = rules.CalcularPremio(poliza.Prima);

            premio.Text = string.Format("{0:###,000.## $}", poliza.Premio);

            cuotas.Text = string.Format("{0:###,000.## $}", (poliza.Premio / 6));
        }

        private void reinciar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            marcas.SelectedIndex = -1;
            modelos.SelectedIndex = -1;
            versiones.SelectedIndex = -1;
            coberturasTipos.SelectedIndex = 0;

            personaSelect = null;
            nombrePersona.Text = string.Empty;
            apellidoPersona.Text = string.Empty;
            emailPersona.Text = string.Empty;
            cuilPersona.Text = string.Empty;
            celularPersona.Text = string.Empty;
            localidadPersona.Text = string.Empty;
            cotizar.Enabled = false;

            prima.Text = string.Empty;
            premio.Text = string.Empty;
            cuotas.Text = string.Empty;
            precio.Text = string.Empty;

            auto.Text = string.Empty;
        }

        private void agregarPersona_Click(object sender, EventArgs e)
        {
            var frm = new PersonasAddForm();
            frm.ShowDialog();
        }

       
    }
}
