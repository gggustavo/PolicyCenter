using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public interface ICalculo
    {
        decimal precio { get; set; }
        string riesgoUbicacion { get; set; }
        int anio { get; set; }
        int idCobertura { get; set; }
        ICalculo Get();
    }
}
