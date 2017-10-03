using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VersionesController
    {
        public IEnumerable<Model.Version> ObtenerVersiones()
        {
            var context = Model.Context.GetInstance();
            return context.Version.Include("Models").ToList();
        }
    }
}
