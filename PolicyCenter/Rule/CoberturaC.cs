﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CoberturaC : Cobertura
    {

        public CoberturaC(Model.Poliza poliza)
        {
            Poliza = poliza;
        }

        public override decimal CalcularPrima()
        {
            var riesgo = new UbicacionRiesgo().RiesgoUbicacion(Poliza.Persona.Localidad.Nombre);
            return Poliza.Bien.Precio * Convert.ToDecimal(0.010) + (Poliza.Bien.Precio * riesgo);
        }
        
    }
}