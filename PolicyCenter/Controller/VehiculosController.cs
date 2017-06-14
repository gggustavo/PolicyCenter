using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VehiculosController
    {
        public IList<Model.Vehiculo> ObtenerVehiculos()
        {
            var context = Model.Context.GetInstance();
            return context.Vehiculo.Include("Marca").Include("Modelo").Include("Version").Include("Ramo").ToList();
        }
    }
}
