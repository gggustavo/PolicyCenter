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
    public partial class PersonasForm : Form
    {

        private Controller.PersonasController personController = new Controller.PersonasController();

        public PersonasForm()
        {
            InitializeComponent();

            ObtenerPersonas();
        }

        private void ObtenerPersonas()
        {
            personaBindingSource.DataSource = personController.ObtenerPersonas().Select(Data);
        }


        private dynamic Data(Model.Persona person)
        {
            return new 
            {
                IdPersona = person.IdPersona,
                Nombre = person.Nombre,
                Apellido = person.Apellido,
                Dni = person.Dni,
                Cuit = person.Cuit,
                Cuil = person.Cuil,
                Edad = person.Edad,
                Celular = person.Celular,
                Email = person.Email,
                Localidad = person.Localidad.Nombre,
                Direccion = person.Direccion.Calle + " " + person.Direccion.Numero
            };
        }

        private void reinciar_Click(object sender, EventArgs e)
        {
            ObtenerPersonas();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            var frm = new PersonasAddForm();
            frm.ShowDialog();
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            if (personaBindingSource.Current == null) MessageBox.Show("Seleccione una persona");

            dynamic current = personaBindingSource.Current;
            var idPersona = current.IdPersona;

            personController.Eliminar(idPersona);

            ObtenerPersonas();
        }
    }
}
