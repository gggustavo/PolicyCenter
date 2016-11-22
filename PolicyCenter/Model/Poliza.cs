using System;

namespace Model
{
    public class Poliza
    {
        public int IdPoliza { get; set; }
        public int Numero { get; set; }
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }
        public int IdVehiculo { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public int IdCobertura { get; set; }
        public Cobertura Cobertura { get; set; }
        public DateTime VigenciaDesde { get; set; }
        public DateTime VigenciaHasta { get; set; }
        public string Estado { get; set; }
    }
}