using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CoberturaD : CoberturaBase
    {
        private ICalculo _calculo;
        private IReglas _reglas;

        public CoberturaD(ICalculo calculo, IReglas reglas)
        {
            PrecioBase = Convert.ToDecimal(0.02);
            _calculo = calculo;
            _reglas = reglas;
        }

        public override decimal CalcularPrima()
        {
            var antiguedad = _reglas.riesgoAntiguedad(_calculo.Anio);
            var riesgo = _reglas.riesgoUbicacion(_calculo.CodigoPostalRiesgo);

            return (_calculo.Precio * PrecioBase) + (_calculo.Precio * riesgo) + (_calculo.Precio * antiguedad);
        }
        
    }
}
