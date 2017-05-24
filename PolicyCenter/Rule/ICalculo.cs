using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public interface ICalculo
    {
        decimal Precio { get; set; }
        string RiesgoUbicacion { get; set; }
        int Anio { get; set; }
        int IdCobertura { get; set; }
        ICalculo Get();
    }

}
