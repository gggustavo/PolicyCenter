using System.Collections.Generic;

namespace Model
{
    public class Cobertura
    {
        public int IdCobertura { get; set; }
        public string Nombre { get; set; }

        public ICollection<Riesgo> Riesgos { get; set; }
    }
}