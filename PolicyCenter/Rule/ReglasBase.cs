using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class ReglasBase : IReglas
    {
        public decimal riesgoUbicacion(int codigoPostal)
        {
            return new UbicacionRiesgo().RiesgoUbicacion(codigoPostal);            
        }

        public decimal riesgoAntiguedad(int anio)
        {
            return new AntiguedadRiesgo().RiegoAntiguedad(anio);            
        }
    }
}
