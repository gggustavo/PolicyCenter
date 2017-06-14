using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class CoberturasController
    {
        public IList<Model.Cobertura> ObtenerCoberturas()
        {
            var context = Model.Context.GetInstance();
            return context.Cobertura.ToList();
        }
    }
}
