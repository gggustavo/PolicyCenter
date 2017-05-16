using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class AntiguedadRiesgo
    {
        private Dictionary<int, decimal> _listAntiguedadRiesgo;

        public AntiguedadRiesgo()
        {
            _listAntiguedadRiesgo = new Dictionary<int, decimal>();
            _listAntiguedadRiesgo.Add(2017, Convert.ToDecimal(0.001));
            _listAntiguedadRiesgo.Add(2016, Convert.ToDecimal(0.004));
            _listAntiguedadRiesgo.Add(2015, Convert.ToDecimal(0.006));
            _listAntiguedadRiesgo.Add(2014, Convert.ToDecimal(0.008));
            _listAntiguedadRiesgo.Add(2013, Convert.ToDecimal(0.010));
            _listAntiguedadRiesgo.Add(2012, Convert.ToDecimal(0.012));
            _listAntiguedadRiesgo.Add(2011, Convert.ToDecimal(0.014));
            _listAntiguedadRiesgo.Add(2010, Convert.ToDecimal(0.016));
            _listAntiguedadRiesgo.Add(2009, Convert.ToDecimal(0.018));
            _listAntiguedadRiesgo.Add(2008, Convert.ToDecimal(0.020));
            _listAntiguedadRiesgo.Add(2007, Convert.ToDecimal(0.022));
            _listAntiguedadRiesgo.Add(2006, Convert.ToDecimal(0.024));
            _listAntiguedadRiesgo.Add(2005, Convert.ToDecimal(0.026));
            _listAntiguedadRiesgo.Add(2004, Convert.ToDecimal(0.028));
       }


        public decimal RiegoAntiguedad(int anio)
        {
            var value = _listAntiguedadRiesgo.FirstOrDefault(_ => _.Key == anio);
            return value.Value;
        }
    }
}

