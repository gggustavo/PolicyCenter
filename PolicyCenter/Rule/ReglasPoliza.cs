using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class ReglasPoliza
    {        
        private ICalculo _calculo;
        private IReglas _reglas;
        private CoberturaFactory _coberturaFactory;

        public ReglasPoliza(Model.Poliza poliza)
        {            
            _calculo = new CalculoBase(poliza).Get();
            _reglas = new ReglasBase();
            _coberturaFactory = new CoberturaFactory();

            _coberturaFactory.RegisterCobertura<CoberturaA>(1);
            _coberturaFactory.RegisterCobertura<CoberturaC>(2);
            _coberturaFactory.RegisterCobertura<CoberturaCPlus>(3);
            _coberturaFactory.RegisterCobertura<CoberturaD>(4);
        }

        public decimal CalcularPrima() 
        {
            var factory = _coberturaFactory.Get(_calculo.IdCobertura);
            return factory.CalcularPrima(_calculo, _reglas);           
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
