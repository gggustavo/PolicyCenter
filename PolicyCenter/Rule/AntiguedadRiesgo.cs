using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class AntiguedadRiesgo
    {
        private List<Entidades.AntiguedadRiesgo> _listAntiguedadRiesgo;

        public AntiguedadRiesgo()
        {            
            _listAntiguedadRiesgo = Context.GetInstance().AntiguedadRiesgo.ToList();
       }


        public decimal RiegoAntiguedad(int anio)
        {
            var value = _listAntiguedadRiesgo.FirstOrDefault(_ => _.Modelo == anio);
            return value.Valor;
        }
    }
}

