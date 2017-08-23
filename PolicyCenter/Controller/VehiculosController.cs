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

        public void Eliminar(int idBien)
        {
            var context = Model.Context.GetInstance();
            var bien = context.Bien.Find(idBien);
            bien.Activo = false;
            context.Entry(bien).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void AgregarVehiculo(Model.Vehiculo vehiculo)
        {
            var context = Model.Context.GetInstance();
            context.Vehiculo.Add(vehiculo);
            context.SaveChanges();
        }
    }
}
