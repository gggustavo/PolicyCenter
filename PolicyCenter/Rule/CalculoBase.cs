using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CalculoBase : ICalculo
    {
        public decimal Precio { get; set; }
        public string RiesgoUbicacion { get; set; }
        public int Anio { get; set; }
        public int IdCobertura { get; set; }

        public CalculoBase(Model.Poliza poliza)
        {
            Precio = poliza.Bien.Precio;
            RiesgoUbicacion = poliza.Persona.Localidad.Nombre;
            Anio = poliza.Bien.Anio;
            IdCobertura = poliza.IdCobertura;
        }

        public ICalculo Get()
        {
            return this;
        }

   
 
    }
}
