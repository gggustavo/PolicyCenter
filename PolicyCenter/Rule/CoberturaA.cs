using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CoberturaA : Cobertura
    {

        public CoberturaA(Model.Poliza poliza)
        {
            Poliza = poliza;
        }

        public override decimal CalcularPrima()
        {
            var riesgo = new UbicacionRiesgo().RiesgoUbicacion(Poliza.Persona.Localidad.Nombre);
             return Poliza.Bien.Precio * Convert.ToDecimal(0.005) + riesgo;
        }
        
    }
}
