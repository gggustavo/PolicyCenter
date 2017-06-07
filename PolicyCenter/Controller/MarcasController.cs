using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class MarcasController
    {
        public IList<Model.Marca> ObtenerMarcas()
        {
            var context = Model.Context.GetInstance();
            return context.Marca.ToList();
        }
    }
}
