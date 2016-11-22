using System.Collections.Generic;

namespace Model
{
    public class Riesgo
    {
        public int IdRiesgo { get; set; }
        public string Nombre { get; set; }

        public ICollection<Cobertura> Coberturas { get; set; }
    }
}