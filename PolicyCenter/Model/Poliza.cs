using System;

namespace Model
{
    public class Poliza
    {
        public int IdPoliza { get; set; }
        public int Numero { get; set; }
        public int IdProductor { get; set; }
        public Productor Productor { get; set; }
        public int IdPersona { get; set; }
        public Persona Persona { get; set; }
        
        
    }
}