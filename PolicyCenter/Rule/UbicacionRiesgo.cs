using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class UbicacionRiesgo
    {
        private List<Entidades.UbicacionRiesgo> _listRiegos;

        public UbicacionRiesgo()
        {
            _listRiegos = Context.GetInstance().UbicacionRiesgo.ToList();
        }

        public decimal RiesgoUbicacion(string localidad)
        {
            var value = _listRiegos.FirstOrDefault(_ => _.Ciudad.ToUpper() == localidad.ToUpper());
            return value.Valor;
        }

    }
}
