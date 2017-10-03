using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rule;

namespace Controller
{
    public class UbicacionRiesgoController
    {
        public IEnumerable<Rule.Entidades.UbicacionRiesgo> ObtenerUbicacionRiesgo()
        {
            var context = Context.GetInstance();
            return context.UbicacionRiesgo.ToList();
        }
    }
}
