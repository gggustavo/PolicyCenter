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
            if (string.IsNullOrEmpty(nombre.Text)) { MessageBox.Show("Ingrese un nombre"); return; }
            if (string.IsNullOrEmpty(apellido.Text)) { MessageBox.Show("Ingrese un apellido"); return; }
            if (string.IsNullOrEmpty(dni.Text)) { MessageBox.Show("Ingrese un dni"); return; }
            if (string.IsNullOrEmpty(edad.Text)) { MessageBox.Show("Ingrese una edad"); return; }
            if (string.IsNullOrEmpty(email.Text)) { MessageBox.Show("Ingrese un email"); return; }
            if (string.IsNullOrEmpty(Celular.Text)) { MessageBox.Show("Ingrese un celular"); return; }
            if (string.IsNullOrEmpty(direccion.Text)) { MessageBox.Show("Ingrese una direccion"); return; }
            if (localidadBindingSource.Current == null) {  MessageBox.Show("Seleccione una localidad"); return; }


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
