using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class OrganizadoresController
    {
        public IEnumerable<Model.Organizador> ObtenerOrganizadores()
        {
            var context = Model.Context.GetInstance();
            return context.Organizador.ToList();
        }
    }
}
