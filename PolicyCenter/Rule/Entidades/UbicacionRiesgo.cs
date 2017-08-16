using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rule.Entidades
{
    public class UbicacionRiesgo
    {
        public int Id { get; set; }
        public int CodigoPostal { get; set; }
        public string Ciudad { get; set; }
        public decimal Valor { get; set; }
    }
}
