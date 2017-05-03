using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class RulePoliza
    {
        private Model.Poliza _poliza;

        public RulePoliza(Model.Poliza poliza)
        {
            _poliza = poliza;
        }

        public decimal ObtenerPrima() 
        {
            //Cobertura A
            //Cobertura C
            //Cobertura C+
            //Cobertura D -> Todo Riesgo !!!
            switch (_poliza.IdCobertura)
            {
                case 1:
                    return _poliza.Bien.Precio * Convert.ToDecimal(0.015);
                case 2:
                    return _poliza.Bien.Precio * Convert.ToDecimal(0.025);
                case 3:
                    return _poliza.Bien.Precio * Convert.ToDecimal(0.035);
                case 4:
                    return _poliza.Bien.Precio * Convert.ToDecimal(0.045);

                default:
                    break;                
            }
            return 0;            
        }

        public decimal ObtenerPremio()
        {
            return ObtenerPrima() + ObtenerImpuestos();
        }

        private decimal ObtenerImpuestos()
        {
            return _poliza.Bien.Precio * Convert.ToDecimal(0.002);
        }

    }
}
