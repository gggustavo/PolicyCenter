using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class UbicacionRiesgo
    {
        private Dictionary<string, decimal> _listRiegos;

        public UbicacionRiesgo()
        {
            _listRiegos = new Dictionary<string, decimal>();
            _listRiegos.Add("BuenosAires", Convert.ToDecimal(0.005));
            _listRiegos.Add("Rosario", Convert.ToDecimal(0.002));
            _listRiegos.Add("Funes", Convert.ToDecimal(0.0015));
            _listRiegos.Add("Casilda", Convert.ToDecimal(0.009));
        }

        public decimal RiesgoUbicacion(string localidad)
        {
            var value = _listRiegos.FirstOrDefault(_ => _.Key.ToUpper() == localidad.ToUpper());
            return value.Value;
        }

    }
}
