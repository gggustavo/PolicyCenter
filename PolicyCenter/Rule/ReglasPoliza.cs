using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class ReglasPoliza
    {
        private Model.Poliza _poliza;

        public ReglasPoliza(Model.Poliza poliza)
        {
            _poliza = poliza;
        }

        public decimal CalcularPrima() 
        {
            //Cobertura A - Cobertura C - Cobertura C+ - Cobertura D -> Todo Riesgo !!!
            switch (_poliza.IdCobertura)
            {
                case 1:
                    return new CoberturaA(_poliza).CalcularPrima();                    
                case 2:
                    return new CoberturaC(_poliza).CalcularPrima();       
                case 3:
                    return new CoberturaCPlus(_poliza).CalcularPrima();   
                case 4:
                    return new CoberturaD(_poliza).CalcularPrima();

                default:
                    break;                
            }
            return 0;            
        }

        public decimal CalcularPremio(decimal prima)
        {           
            //Rec.Administ 20% (s/ prima)
            //Rec.Financ 8% (s/ prima)                        
            var recAdmin = prima * Convert.ToDecimal(0.2);
            var recFinac = prima * Convert.ToDecimal(0.08);
            var subTotal = prima + recAdmin + recFinac;
            //IVA 21%
            //Otros imp. 5%
            var iva = subTotal * Convert.ToDecimal(0.21);
            var otroimp = subTotal * Convert.ToDecimal(0.05);
            return subTotal + iva + otroimp;
        }

        
    }
}
