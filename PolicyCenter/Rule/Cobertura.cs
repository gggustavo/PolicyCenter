using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public abstract class Cobertura
    {
        public Model.Poliza Poliza { get; set; }

        public abstract decimal CalcularPrima();
    }
}
