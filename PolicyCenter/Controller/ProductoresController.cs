using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ProductoresController
    {
        public IList<Model.Productor> ObtenerProductores()
        {
            var context = Model.Context.GetInstance();
            return context.Productor.ToList();
        }
    }
}
