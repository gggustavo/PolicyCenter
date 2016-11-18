using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Model
{
    internal class ContextInitializer : DropCreateDatabaseIfModelChanges<PolicyCenterContext>
    {
        protected override void Seed(PolicyCenterContext context)
        {
            CargarMarcas(context);
            CargarModeloVw(context);
            CargarLocalidades(context);
            CargarPersona(context);
            CargarOrganizadorProductor(context);

            base.Seed(context);
        }

        private static void CargarModeloVw(PolicyCenterContext context)
        {
            var modelos = new List<Modelo>();

            var versions = new List<Version>
            {
                new Version {Nombre = "Starline 4X2 MY16"},
                new Version {Nombre = "Starline 4X4 MY16"}
            };


            var modelo = new Modelo
            {
                Nombre = "Amarok DC 2.0L TDI 140 CV",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);

            versions = new List<Version>
            {
                new Version {Nombre = "Black Package 4X4 AUT MY16"},
                new Version {Nombre = "Black Package 4X4 MY16"},
                new Version {Nombre = "Dark Label 4x2 AUT MY16"},
                new Version {Nombre = "Dark Label 4x2 MY16"},
                new Version {Nombre = "Dark Label 4x4 AUT MY16"},
                new Version {Nombre = "Dark Label 4x4 MY16"},
                new Version {Nombre = "Highline Pack 4x2 AUT MY16"},
                new Version {Nombre = "Highline Pack 4x2 MY16"},
                new Version {Nombre = "Highline Pack 4x4 AUT MY16"},
                new Version {Nombre = "Highline Pack 4x4 MY16"},
                new Version {Nombre = "Trendline Pack 4x2 AUT MY16"},
                new Version {Nombre = "Trendline Pack 4x2 MY16"},
                new Version {Nombre = "Trendline Pack 4x4 AUT MY16"},
                new Version {Nombre = "Trendline Pack 4x4 MY16"},
                new Version {Nombre = "Ultimate 4x2 AUT MY16"},
                new Version {Nombre = "Ultimate 4x2 MY16"},
                new Version {Nombre = "Ultimate 4x4 AUT MY16"},
                new Version {Nombre = "Ultimate 4x4 MY16"}
            };

            modelo = new Modelo
            {
                Nombre = "Amarok DC 2.0L TDI 180 CV",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                context.Version.SingleOrDefault(_ => _.IdVersion == 1),
                context.Version.SingleOrDefault(_ => _.IdVersion == 2)
            };


            modelo = new Modelo
            {
                Nombre = "Amarok SC 2.0L TDI 140 CV",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version> {new Version {Nombre = "Elegance DSG"}};

            modelo = new Modelo
            {
                Nombre = "CC 2.0 TSI ",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Higline manual MY16"},
                new Version {Nombre = "Higline manual MY17"}
            };


            modelo = new Modelo
            {
                Nombre = "CrossFox 1.6 MSI 16V",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Comfortline manual"},
                new Version {Nombre = "Track manual"},
                new Version {Nombre = "Trendline manual"}
            };


            modelo = new Modelo
            {
                Nombre = "Fox 1.6 MSI",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Higline I Motion"},
                new Version {Nombre = "Higline manual"},
                new Version {Nombre = "Pepper"}
            };


            modelo = new Modelo
            {
                Nombre = "Fox 1.6 MSI 16V",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Connect manual 5P MY17"},
                new Version {Nombre = "Highline I-Motion MY17"},
                new Version {Nombre = "Highline manual 5P MY17"},
                new Version {Nombre = "Serie manual 3P MY17"},
                new Version {Nombre = "Serie manual 5P MY17"},
                new Version {Nombre = "Sportline manual 5P MY17"},
                new Version {Nombre = "Trendline manual 3P MY17"},
                new Version {Nombre = "Trendline manual 5P MY17"}
            };


            modelo = new Modelo
            {
                Nombre = "Gol Trend",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Comfortline DSG MY16"},
                new Version {Nombre = "Comfortline manual DSG MY16"},
                new Version {Nombre = "Highline DSG MY16"}
            };


            modelo = new Modelo
            {
                Nombre = "Golf 1.4 TSI",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version> {new Version {Nombre = "Trendline Manual MY16"}};


            modelo = new Modelo
            {
                Nombre = "Golf 1.6",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "GTI"},
                new Version {Nombre = "GTI + App Connect"},
                new Version {Nombre = "GTI + App Connect + Cuero"},
                new Version {Nombre = "GTI MY15"},
                new Version {Nombre = "GTI MY15 + Cuero"}
            };


            modelo = new Modelo
            {
                Nombre = "Golf 2.0 TSI",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                context.Version.SingleOrDefault(_ => _.IdVersion == 38),
                context.Version.SingleOrDefault(_ => _.IdVersion == 39),
                context.Version.SingleOrDefault(_ => _.IdVersion == 40)
            };


            modelo = new Modelo
            {
                Nombre = "Golf Variant 1.4 TSI",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Trendline Aut. MY16"},
                context.Version.SingleOrDefault(_ => _.IdVersion == 41)
            };


            modelo = new Modelo
            {
                Nombre = "Golf Variant 1.6",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                context.Version.SingleOrDefault(_ => _.IdVersion == 24),
                new Version {Nombre = "Comfortline Tiptronic"}
            };


            modelo = new Modelo
            {
                Nombre = "Polo 1.6",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version> {new Version {Nombre = "Cabina Doble + Pack High MY17"}};


            modelo = new Modelo
            {
                Nombre = "Saveiro Cross GP 1.6",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                context.Version.SingleOrDefault(_ => _.IdVersion == 49),
                new Version {Nombre = "Cabina Doble + Power MY17"},
                new Version {Nombre = "Cabina Ext. + Safety + Pack High MY17"},
                new Version {Nombre = "Cabina Ext. + Safety MY17"},
                new Version {Nombre = "Cabina Simple + Safety MY17"}
            };


            modelo = new Modelo
            {
                Nombre = "Saveiro GP 1.6",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version> {new Version {Nombre = "DSG"}};


            modelo = new Modelo
            {
                Nombre = "Scirocco 2.0 TSI (GTS)",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                context.Version.FirstOrDefault(_ => _.IdVersion == 24),
                context.Version.FirstOrDefault(_ => _.IdVersion == 26)
            };


            modelo = new Modelo
            {
                Nombre = "Suran 1.6 MSI",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                context.Version.FirstOrDefault(_ => _.IdVersion == 27),
                context.Version.FirstOrDefault(_ => _.IdVersion == 28)
            };


            modelo = new Modelo
            {
                Nombre = "Suran 1.6 MSI 16V",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version> {context.Version.FirstOrDefault(_ => _.IdVersion == 28)};


            modelo = new Modelo
            {
                Nombre = "Suran Cross 1.6 MSI 16V",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Design DSG MY16"},
                new Version {Nombre = "Design Manual DSG MY16"}
            };


            modelo = new Modelo
            {
                Nombre = "The Beetle 1.4 TSI",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Sport DSG MY16"},
                new Version {Nombre = "Sport Manual DSG MY16"}
            };


            modelo = new Modelo
            {
                Nombre = "The Beetle 2.0 TSI",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Premium Tiptonic"},
                new Version {Nombre = "Sport & Style Tiptonic"}
            };


            modelo = new Modelo
            {
                Nombre = "Tiguan 2.0 TSI",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version> {new Version {Nombre = "Premium"}};


            modelo = new Modelo
            {
                Nombre = "Touareg 3.0 V6 TDI ",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version> {context.Version.FirstOrDefault(_ => _.IdVersion == 61)};


            modelo = new Modelo
            {
                Nombre = "Touareg 4.2 V8 FSI",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "back up! 5P"},
                new Version {Nombre = "cross up! 5P"},
                new Version {Nombre = "high up! 3P"},
                new Version {Nombre = "high up! 5P"},
                new Version {Nombre = "high up! 5P I-Motion"},
                new Version {Nombre = "move up! 3P"},
                new Version {Nombre = "move up! 5P"},
                new Version {Nombre = "move up! 5P I-Motion"},
                new Version {Nombre = "take up! +AA 3P"},
                new Version {Nombre = "take up! +AA 5P"},
                new Version {Nombre = "with up! 5P"}
            };


            modelo = new Modelo
            {
                Nombre = "up! 1.0",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Comfortline DSG"},
                context.Version.FirstOrDefault(_ => _.IdVersion == 24),
                new Version {Nombre = "Highline DSG"},
                context.Version.FirstOrDefault(_ => _.IdVersion == 28)
            };


            modelo = new Modelo
            {
                Nombre = "Vento 1.4 150 cv",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Advance Manual + Summer Pack MY16"},
                new Version {Nombre = "Advance Manual MY16"}
            };


            modelo = new Modelo
            {
                Nombre = "Vento 2.0 115 cv",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version> {context.Version.FirstOrDefault(_ => _.IdVersion == 75)};


            modelo = new Modelo
            {
                Nombre = "Vento 2.0 TDI 110 cv",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "GLI DSG MY16 + App Connect"},
                new Version {Nombre = "GLI DSG MY16 + App Connect + Navegador"},
                new Version {Nombre = "GLI DSG MY17 + App Connect + Navegador"},
                new Version {Nombre = "GLI Manual MY16 + App Connect"},
                new Version {Nombre = "GLI Manual MY16 + App Connect + Navegador"}
            };


            modelo = new Modelo
            {
                Nombre = "Vento 2.0 TSI 211 cv",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Advance Plus Manual MY16"},
                new Version {Nombre = "Advance Plus Tiptronic MY16"},
                new Version {Nombre = "Luxury Manual MY16"},
                new Version {Nombre = "Luxury Tiptronic MY16"}
            };


            modelo = new Modelo
            {
                Nombre = "Vento 2.5 170 cv",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            versions = new List<Version>
            {
                new Version {Nombre = "Highline MY17"},
                new Version {Nombre = "Trendline MY17"}
            };


            modelo = new Modelo
            {
                Nombre = "Voyage 1.6",
                IdMarca = 10,
                Versions = versions
            };

            modelos.Add(modelo);
            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos.Clear();
            
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

        private static void CargarLocalidades(PolicyCenterContext context)
        {
            var localidad = new Localidad
            {
                CodPostal = 2000,
                Nombre = "Rosario"
            };
            context.Localidad.Add(localidad);
            context.SaveChanges();
        }

        private static void CargarPersona(PolicyCenterContext context)
        {
            var direccion = new Direccion
            {
               Calle = "Paraguay",
               Departamento = "3",
               Numero = 1538,
               Piso = 1
            };

            var persona = new Persona
            {
                Direccion =  direccion,
                Apellido = "Juan",
                Nombre = "Pedro",
                Dni = "23456456",
                Email = "juan.pedro@hotmail.com",
                Edad = 49,
                Celular = "3415332233",
                Localidad = context.Localidad.FirstOrDefault(),
                Cuil = "20-23456456-9"
            };

            context.Persona.Add(persona);
            context.SaveChanges();
        }

        private static void CargarOrganizadorProductor(PolicyCenterContext context)
        {
            var productor = new Productor
            {
                Nombre = "Juan Valdez"
            };

            context.Productor.Add(productor);
            context.SaveChanges();

            var organizador = new Organizador
            {
                Nombre = "Casa Central S.A",
                IdProductor = 1
            };

            context.Organizador.Add(organizador);
            context.SaveChanges();

        }

    }
}

