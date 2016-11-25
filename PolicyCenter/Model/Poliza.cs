using System;

namespace Model
{
    public class Poliza
    {
        public int IdPoliza { get; set; }
        public long Numero { get; set; }
        public int IdProductor { get; set; }
        public Productor Productor { get; set; }
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }
        public int IdBien { get; set; }
        public Bien Bien { get; set; }

        public int IdCobertura { get; set; }
        public Cobertura Cobertura { get; set; }

        public DateTime VigenciaDesde { get; set; }
        public DateTime VigenciaHasta { get; set; }
        public string Estado { get; set; }

        public decimal Prima { get; set; }
        public decimal Premio { get; set; }

    }
}