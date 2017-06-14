using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PersonasController
    {
        public IList<Model.Persona> ObtenerPersonas()
        {
            var context = Model.Context.GetInstance();
            return context.Persona.Include("Direccion").Include("Localidad").ToList();
        }
    }
}
