using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CoberturaC : CoberturaBase
    {
        private ICalculo _calculo;
        private IReglas _reglas;

        public CoberturaC(ICalculo calculo, IReglas reglas)
        {
            _calculo = calculo;
            _reglas = reglas;
            PrecioBase = Convert.ToDecimal(0.010);            
        }

        public override decimal CalcularPrima()
        {
            var antiguedad = _reglas.riesgoAntiguedad(_calculo.Anio);
            var riesgo = _reglas.riesgoUbicacion(_calculo.RiesgoUbicacion);

            return (_calculo.Precio * PrecioBase) + (_calculo.Precio * riesgo) + (_calculo.Precio * antiguedad);
        }
        
    }
}
