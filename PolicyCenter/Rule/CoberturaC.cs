﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CoberturaC : CoberturaBase
    {
        public CoberturaC(ICalculo calculo, IReglas reglas)
        {
            Calculo = calculo;
            PrecioBase = Convert.ToDecimal(0.010);
            Reglas = reglas;
        }

        public override decimal CalcularPrima()
        {
            var antiguedad = Reglas.riesgoAntiguedad(Calculo.anio);
            var riesgo = Reglas.riesgoUbicacion(Calculo.riesgoUbicacion);

            return (Calculo.precio * PrecioBase) + (Calculo.precio * riesgo) + (Calculo.precio * antiguedad);
        }
        
    }
}
