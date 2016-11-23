using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PolizaDetalle
    {
        public int IdPolizaDetalle { get; set; }
        public int IdPoliza { get; set; }
        public Poliza Poliza { get; set; }

        public int IdVehiculo { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public int IdCobertura { get; set; }
        public Cobertura Cobertura { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime VigenciaHasta { get; set; }
        public string Estado { get; set; }

        public decimal Prima { get; set; }
        public decimal Premio { get; set; }

    }
}
