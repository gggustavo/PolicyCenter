using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CoberturaD : CoberturaBase
    {
        public CoberturaD()
        {
            PrecioBase = Convert.ToDecimal(0.02);
        }

        public override decimal CalcularPrima(ICalculo calculo, IReglas reglas)
        {
            var antiguedad = reglas.riesgoAntiguedad(calculo.Anio);
            var riesgo = reglas.riesgoUbicacion(calculo.RiesgoUbicacion);

            return (calculo.Precio * PrecioBase) + (calculo.Precio * riesgo) + (calculo.Precio * antiguedad);
        }
        
    }
}
