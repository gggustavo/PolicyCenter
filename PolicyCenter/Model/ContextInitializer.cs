using System.Collections.Generic;
using System.Data.Entity;

namespace Model
{
    internal class ContextInitializer : DropCreateDatabaseIfModelChanges<PolicyCenterContext>
    {
        protected override void Seed(PolicyCenterContext context)
        {
            CargarMarcas(context);

            base.Seed(context);
        }

        private static void CargarMarcas(PolicyCenterContext context)
        {
            var marcas = new List<Marca>();

            var marca = new Marca
            {
                Nombre = "Audi"
            };
            marcas.Add(marca);

            marca = new Marca
            {
                Nombre = "BMW"
            };
            marcas.Add(marca);

            marca = new Marca
            {
                Nombre = "Chevrolet"
            };
            marcas.Add(marca);

            marca = new Marca
            {
                Nombre = "Citroen"
            };
            marcas.Add(marca);

            marca = new Marca
            {
                Nombre = "Ford"
            };
            marcas.Add(marca);

            marca = new Marca
            {
                Nombre = "Peugeot"
            };
            marcas.Add(marca);

            marca = new Marca
            {
                Nombre = "Renaut"
            };
            marcas.Add(marca);

            marca = new Marca
            {
                Nombre = "Toyota"
            };
            marcas.Add(marca);

            marca = new Marca
            {
                Nombre = "Peugeot"
            };
            marcas.Add(marca);

            marca = new Marca
            {
                Nombre = "Volkswagen"
            };
            marcas.Add(marca);

            context.Marca.AddRange(marcas);
            context.SaveChanges();

        }
    }
}