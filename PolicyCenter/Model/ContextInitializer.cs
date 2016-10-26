using System.Collections.Generic;
using System.Data.Entity;

namespace Model
{
    internal class ContextInitializer : DropCreateDatabaseIfModelChanges<PolicyCenterContext>
    {
        protected override void Seed(PolicyCenterContext context)
        {
            CargarMarcas(context);
            CargarModelo(context);

            base.Seed(context);
        }

        private void CargarModelo(PolicyCenterContext context)
        {
            var modelos = new List<Modelo>();

            var versiones = new List<Version>();

            versiones.Add(new Version { Nombre = "Starline 4X2 MY16" });
            versiones.Add(new Version { Nombre = "Starline 4X4 MY16" });

            var modelo = new Modelo
            {
                Nombre = "Amarok DC 2.0L TDI 140 CV",
                IdMarca = 10,
                Versions = versiones
            };

            modelos.Add(modelo);

            versiones = new List<Version>();
            versiones.Add(new Version { Nombre = "Black Package 4X4 AUT MY16" });
            versiones.Add(new Version { Nombre = "Black Package 4X4 MY16" });
            versiones.Add(new Version { Nombre = "Dark Label 4x2 AUT MY16" });
            versiones.Add(new Version { Nombre = "Dark Label 4x2 MY16" });
            versiones.Add(new Version { Nombre = "Dark Label 4x4 AUT MY16" });
            versiones.Add(new Version { Nombre = "Dark Label 4x4 MY16" });
            versiones.Add(new Version { Nombre = "Highline Pack 4x2 AUT MY16" });
            versiones.Add(new Version { Nombre = "Highline Pack 4x2 MY16" });
            versiones.Add(new Version { Nombre = "Highline Pack 4x4 AUT MY16" });
            versiones.Add(new Version { Nombre = "Highline Pack 4x4 MY16" });
            versiones.Add(new Version { Nombre = "Trendline Pack 4x2 AUT MY16" });
            versiones.Add(new Version { Nombre = "Trendline Pack 4x2 MY16" });
            versiones.Add(new Version { Nombre = "Trendline Pack 4x4 AUT MY16" });
            versiones.Add(new Version { Nombre = "Trendline Pack 4x4 MY16" });
            versiones.Add(new Version { Nombre = "Ultimate 4x2 AUT MY16" });
            versiones.Add(new Version { Nombre = "Ultimate 4x2 MY16" });
            versiones.Add(new Version { Nombre = "Ultimate 4x4 AUT MY16" });
            versiones.Add(new Version { Nombre = "Ultimate 4x4 MY16" });

            modelo = new Modelo
            {
                Nombre = "Amarok DC 2.0L TDI 180 CV",
                IdMarca = 10,
                Versions = versiones
            };

            modelos.Add(modelo);            

            modelo = new Modelo
            {
                Nombre = "Amarok SC 2.0L TDI 140 CV",
                IdMarca = 10                
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "CC 2.0 TSI ",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "CrossFox 1.6 MSI 16V",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Fox 1.6 MSI",
                IdMarca = 10
            };

            modelos.Add(modelo);


            modelo = new Modelo
            {
                Nombre = "Fox 1.6 MSI 16V",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Gol Trend",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Golf 1.4 TSI",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Golf 1.6",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Golf 2.0 TSI",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Golf Variant 1.4 TSI",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Golf Variant 1.6",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Polo 1.6",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Saveiro Cross GP 1.6",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Saveiro GP 1.6",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Scirocco 2.0 TSI (GTS)",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Suran 1.6 MSI",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Suran 1.6 MSI 16V",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Suran Cross 1.6 MSI 16V",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "The Beetle 1.4 TSI",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "The Beetle 2.0 TSI",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Tiguan 2.0 TSI",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Touareg 3.0 V6 TDI ",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Touareg 4.2 V8 FSI",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "up! 1.0",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Vento 1.4 150 cv",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Vento 2.0 115 cv",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Vento 2.0 TDI 110 cv",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Vento 2.0 TSI 211 cv",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Vento 2.5 170 cv",
                IdMarca = 10
            };

            modelos.Add(modelo);

            modelo = new Modelo
            {
                Nombre = "Voyage 1.6",
                IdMarca = 10
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();
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