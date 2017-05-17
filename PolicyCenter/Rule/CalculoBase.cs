using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule
{
    public class CalculoBase : ICalculo
    {
        public CalculoBase(Model.Poliza poliza)
        {
            _precio = poliza.Bien.Precio;
            _riesgoUbicacion = poliza.Persona.Localidad.Nombre;
            _anio = poliza.Bien.Anio;
            _idcobertura = poliza.IdCobertura;
        }

        private decimal _precio;

        public decimal precio
        {
            get
            {
                return _precio;
            }
            set
            {
                _precio = value;
            }
        }

        private string _riesgoUbicacion;

        public string riesgoUbicacion
        {
            get
            {
                return _riesgoUbicacion;
            }
            set
            {
                _riesgoUbicacion = value;
            }
        }

        private int _anio;

        public int anio
        {
            get
            {
                return _anio;
            }
            set
            {
                _anio = value;
            }
        }


        public ICalculo Get()
        {
            return this;
        }

        private int _idcobertura;
        public int idCobertura
        {
            get
            {
                return _idcobertura;
            }
            set
            {
                _idcobertura = value;
            }
        }
    }
}
