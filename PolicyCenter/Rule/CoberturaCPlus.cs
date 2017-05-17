using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CoberturaCPlus : CoberturaBase
    {

        public CoberturaCPlus(ICalculo cobertura, IReglas reglas)
        {
            Cobertura = cobertura;
            PrecioBase = Convert.ToDecimal(0.015);
            Reglas = reglas;
        }

        public override decimal CalcularPrima()
        {
            var antiguedad = Reglas.riesgoAntiguedad(Cobertura.anio);
            var riesgo = Reglas.riesgoUbicacion(Cobertura.riesgoUbicacion);

            return (Cobertura.precio * PrecioBase) + (Cobertura.precio * riesgo) + (Cobertura.precio * antiguedad);
        }
        
    }
}
