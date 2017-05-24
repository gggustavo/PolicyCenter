﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CoberturaC : CoberturaBase
    {
        public CoberturaC()
        {            
            PrecioBase = Convert.ToDecimal(0.010);            
        }

        public override decimal CalcularPrima(ICalculo calculo, IReglas reglas)
        {
            var antiguedad = reglas.riesgoAntiguedad(calculo.Anio);
            var riesgo = reglas.riesgoUbicacion(calculo.RiesgoUbicacion);

            return (calculo.Precio * PrecioBase) + (calculo.Precio * riesgo) + (calculo.Precio * antiguedad);
        }
        
    }
}
