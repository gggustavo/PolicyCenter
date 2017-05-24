using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public abstract class CoberturaBase
    {
        public decimal PrecioBase { get; set; }
        public abstract decimal CalcularPrima(ICalculo calculo, IReglas reglas);
    }
}
