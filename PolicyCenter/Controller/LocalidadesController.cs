using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LocalidadesController
    {
        public IList<Model.Localidad> ObtenerLocalidades()
        {
            var context = Model.Context.GetInstance();
            return context.Localidad.ToList();
        }

        public Model.Localidad ObtenerLocalidadesId(int id)
        {
            var context = Model.Context.GetInstance();
            return context.Localidad.Find(id);
        }


    }
}
