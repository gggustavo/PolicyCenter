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
    public partial class PersonasAddForm : Form
    {
        private Controller.PersonasController personController;
        private Controller.LocalidadesController localidadController;

        public PersonasAddForm()
        {
            InitializeComponent();

            personController = new Controller.PersonasController();
            localidadController = new Controller.LocalidadesController();

            localidadBindingSource.DataSource = localidadController.ObtenerLocalidades();
        }

        private void confirmar_Click(object sender, EventArgs e)
        {
            var persona = new Model.Persona();

            persona.Nombre = nombre.Text;
            persona.Apellido = apellido.Text;
            persona.Dni = dni.Text;
            persona.Cuil = cuil.Text;
            persona.Cuit = cuil.Text;
            var edadout = 0;
            int.TryParse(edad.Text, out edadout);
            persona.Edad = edadout;
            persona.Email = email.Text;
            persona.Celular = Celular.Text;
            persona.Direccion = new Model.Direccion { Calle = direccion.Text };
            persona.IdLocalidad = ((Model.Localidad)localidadBindingSource.Current).IdLocalidad;

            personController.AgregarPersona(persona);
            Close();
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
