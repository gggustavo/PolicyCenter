using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public interface IReglas
    {
        decimal riesgoUbicacion(int codigoPostal);
        decimal riesgoAntiguedad(int anio);
    }
}
