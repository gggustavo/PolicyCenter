using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class RamosController
    {
        public IEnumerable<Model.Ramo> ObtenerRamos()
        {
            var context = Model.Context.GetInstance();
            return context.Ramo.ToList();
        }
    }
}
