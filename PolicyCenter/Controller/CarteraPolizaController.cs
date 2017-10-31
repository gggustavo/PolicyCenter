using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CarteraPolizaController
    {
        public IEnumerable<Model.Poliza> ObtenerPolizas()
        {
            var context = Model.Context.GetInstance();
            return context.Poliza.Include("Productor").Include("Persona").Include("Cobertura").Include("Bien").ToList();
        }

      
    }
}
