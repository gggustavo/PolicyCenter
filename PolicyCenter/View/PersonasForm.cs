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

            personaBindingSource.DataSource = personController.ObtenerPersonas()
                                                              .Select(_ => new { IdPersona = _.IdPersona , Nombre = _.Nombre,
                                                                                 Apellido = _.Apellido, Dni = _.Dni, Cuit = _.Cuit,
                                                                                 Cuil = _.Cuil, Edad = _.Edad, Celular = _.Celular,
                                                                                 Email = _.Email, Localidad = _.Localidad.Nombre,
                                                                                 Direccion = _.Direccion.Calle + " " + _.Direccion.Numero
                                                                                });
        }
    }
}
