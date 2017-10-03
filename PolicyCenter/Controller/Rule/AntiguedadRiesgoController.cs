using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rule;

namespace Controller
{
    public class AntiguedadRiesgoController
    {
        public IEnumerable<Rule.Entidades.AntiguedadRiesgo> ObtenerAntiguedadRiesgo()
        {
            var context = Context.GetInstance();
            return context.AntiguedadRiesgo.ToList();
        }
    }
}
