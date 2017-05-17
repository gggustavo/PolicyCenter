using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class ReglasBase : IReglas
    {
        public decimal riesgoUbicacion(string ubicacion)
        {
            return new UbicacionRiesgo().RiesgoUbicacion(ubicacion);            
        }

        public decimal riesgoAntiguedad(int anio)
        {
            return new AntiguedadRiesgo().RiegoAntiguedad(anio);            
        }
    }
}
