using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ModelosController
    {
        public IEnumerable<Model.Modelo> ObtenerModelos()
        {
            var context = Model.Context.GetInstance();
            return context.Modelo.Include("Marca").ToList();
        }
    }
}
