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

        public CoberturaFactory()
        {
            _coberturas = new Dictionary<int, Type>();
        }

        public void RegisterCobertura<cobertura>(int id) where cobertura : CoberturaBase
        {
            _coberturas.Add(id, typeof(cobertura));
        }

        public CoberturaBase Get(int id)
        {
            return (CoberturaBase)Activator.CreateInstance(_coberturas[id]);
        }
    }
}
