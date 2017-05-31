using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CoberturaFactory
    {
        private Dictionary<int, Type> _coberturas;
        private ICalculo _calculo;
        private IReglas _reglas;

        public CoberturaFactory(ICalculo calculo, IReglas reglas)
        {
            _coberturas = new Dictionary<int, Type>();
            _calculo = calculo;
            _reglas = reglas;
        }

        public void RegisterCobertura<cobertura>(int id) where cobertura : CoberturaBase
        {
            _coberturas.Add(id, typeof(cobertura));
        }

        public CoberturaBase Get(int id)
        {
            return (CoberturaBase)Activator.CreateInstance(_coberturas[id], _calculo, _reglas);
        }
    }
}
