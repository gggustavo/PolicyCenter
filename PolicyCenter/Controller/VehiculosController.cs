using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class VehiculosController
    {
        public IEnumerable<Model.Vehiculo> ObtenerVehiculos()
        {
            var context = Model.Context.GetInstance();
            return context.Vehiculo.Include("Marca").Include("Modelo").Include("Version").Include("Ramo")
                .Where(_ => _.Activo).ToList();
        }

        public Model.Vehiculo ObtenerVehiculo(int idBien)
        {
            var context = Model.Context.GetInstance();
            return context.Vehiculo.Include("Marca").Include("Modelo").Include("Version").Include("Ramo").FirstOrDefault(_ => _.IdBien == idBien);
        }

        public void Eliminar(int idBien)
        {
            var context = Model.Context.GetInstance();
            var bien = context.Bien.Find(idBien);
            bien.Activo = false;
            context.Entry(bien).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void ModificarVehiculo(Model.Vehiculo vehiculo)
        {
            var context = Model.Context.GetInstance();

            var currentPrice = context.Vehiculo.AsNoTracking().FirstOrDefault(_ => _.IdBien == vehiculo.IdBien).Precio;

            var history = new Model.HistoriaBien { Bien = vehiculo, Precio = currentPrice, Updated = DateTime.Now };
            context.Entry(vehiculo).State = System.Data.Entity.EntityState.Modified;

            context.HistoriaBien.Add(history);

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
