using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public static class Test
    {
        public static void Initialize()
        {
            var context = new Model.PolicyCenterContext();
            var marcas = context.Marca.ToList();

        }
    }
}
