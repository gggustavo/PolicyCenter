﻿using System;
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
            CargarModeloCitroen(context);
            CargarLocalidades(context);
            CargarPersona(context);
            CargarOrganizadorProductor(context);
            CargarRiesgos(context);
            CargarCoberturas(context);
            CargarRamos(context);
            CargarVehiculos(context);
            CargarPolizas(context);
           
            base.Seed(context);
        }

        private static void CargarModeloVw(PolicyCenterContext context)
        {
            var modelos = new List<Modelo>();

            var versions = new List<Version>
            {
                new Version {Nombre = "Starline 4X2"},
                new Version {Nombre = "Starline 4X4"}
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
                new Version {Nombre = "Black Package 4X4 AUT"},
                new Version {Nombre = "Black Package 4X4"},
                new Version {Nombre = "Dark Label 4x2 AUT"},
                new Version {Nombre = "Dark Label 4x2"},
                new Version {Nombre = "Dark Label 4x4 AUT"},
                new Version {Nombre = "Dark Label 4x4"},
                new Version {Nombre = "Highline Pack 4x2 AUT"},
                new Version {Nombre = "Highline Pack 4x2"},
                new Version {Nombre = "Highline Pack 4x4 AUT"},
                new Version {Nombre = "Highline Pack 4x4"},
                new Version {Nombre = "Trendline Pack 4x2 AUT"},
                new Version {Nombre = "Trendline Pack 4x2"},
                new Version {Nombre = "Trendline Pack 4x4 AUT"},
                new Version {Nombre = "Trendline Pack 4x4"},
                new Version {Nombre = "Ultimate 4x2 AUT"},
                new Version {Nombre = "Ultimate 4x2"},
                new Version {Nombre = "Ultimate 4x4 AUT"},
                new Version {Nombre = "Ultimate 4x4"}
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
                new Version {Nombre = "Higline manual"},
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
                new Version {Nombre = "Comfortline DSG"},
                new Version {Nombre = "Comfortline manual DSG"},
                new Version {Nombre = "Highline DSG"}
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
            versions = new List<Version> {new Version {Nombre = "Trendline Manual"}};


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
                new Version {Nombre = "Trendline Aut."},
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
                new Version {Nombre = "Design DSG"},
                new Version {Nombre = "Design Manual DSG"}
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
                new Version {Nombre = "Sport DSG"},
                new Version {Nombre = "Sport Manual DSG"}
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
                new Version {Nombre = "Advance Manual + Summer Pack"},
                new Version {Nombre = "Advance Manual"}
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
                new Version {Nombre = "GLI DSG + App Connect"},
                new Version {Nombre = "GLI DSG + App Connect + Navegador"},
                new Version {Nombre = "GLI DSG MY17 + App Connect + Navegador"},
                new Version {Nombre = "GLI Manual + App Connect"},
                new Version {Nombre = "GLI Manual + App Connect + Navegador"}
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
                new Version {Nombre = "Advance Plus Manual"},
                new Version {Nombre = "Advance Plus Tiptronic"},
                new Version {Nombre = "Luxury Manual"},
                new Version {Nombre = "Luxury Tiptronic"}
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

        private static void CargarModeloCitroen(PolicyCenterContext context)
        {
            var modelos = new List<Modelo>();

            var versions = new List<Version>
            {
                new Version {Nombre = "Live VTi"},
                new Version {Nombre = "Feel VTi"},
                new Version {Nombre = "Feel VTi Aut"},
                new Version {Nombre = "Shine VTi"},
                new Version {Nombre = "Shine VTi Aut"}
            };


            var modelo = new Modelo
            {
                Nombre = "C3",
                IdMarca = 4,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos = new List<Modelo>();

            versions = new List<Version>
            {
                new Version {Nombre = "VTi 115 Live"},
                new Version {Nombre = "VTi 115 Feel"},
                new Version {Nombre = "VTi 92 Feel HDi"},
                new Version {Nombre = "VTi 115 Shine Aut"}                
            };


            modelo = new Modelo
            {
                Nombre = "C-Elysée",
                IdMarca = 4,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos = new List<Modelo>();

            versions = new List<Version>
            {
                new Version {Nombre = "Feel VTi"},
                new Version {Nombre = "Feel VTi Aut"},
                new Version {Nombre = "Shine VTi"},
                new Version {Nombre = "Shine VTi Aut"},
            };


            modelo = new Modelo
            {
                Nombre = "C3 Aircross",
                IdMarca = 4,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();


            modelos = new List<Modelo>();

            versions = new List<Version>
            {
                new Version {Nombre = "Shine Aut"}
            };

            modelo = new Modelo
            {
                Nombre = "C4 Cactus",
                IdMarca = 4,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos = new List<Modelo>();

            versions = new List<Version>
            {
                new Version {Nombre = "1.6 Feel"},
                new Version {Nombre = "1.6 Feel Aut"},
                new Version {Nombre = "1.6 HDi Feel Pack"},
                new Version {Nombre = "1.6 HDi Pack"},
                new Version {Nombre = "1.6 HDi Feel Pack 10 años"},
                new Version {Nombre = "1.6 Feel Pack 10 años"},
                new Version {Nombre = "1.6 Shine Aut"}
            };

            modelo = new Modelo
            {
                Nombre = "C4 Lounge",
                IdMarca = 4,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos = new List<Modelo>();

            versions = new List<Version>
            {
                new Version {Nombre = "1.6 HDi Feel"},
                new Version {Nombre = "1.6 HDi Feel Aut"},
                new Version {Nombre = "1.6 HDi Feel Pack"},
                new Version {Nombre = "1.6 HDi Feel Pack Aut"}
            };

            modelo = new Modelo
            {
                Nombre = "C4 Picasso",
                IdMarca = 4,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos = new List<Modelo>();

            versions = new List<Version>
            {
                new Version {Nombre = "1.6 Feel Pack Aut"},
                new Version {Nombre = "1.6 HDi Shine"},
                new Version {Nombre = "1.6 Shine Aut"}
            };

            modelo = new Modelo
            {
                Nombre = "C4 Grand Picasso",
                IdMarca = 4,
                Versions = versions
            };

            modelos.Add(modelo);

            context.Modelo.AddRange(modelos);
            context.SaveChanges();

            modelos = new List<Modelo>();

            versions = new List<Version>
            {
                new Version {Nombre = "1.6 XTR"},
                new Version {Nombre = "1.6 HDi XTR"},
            };

            modelo = new Modelo
            {
                Nombre = "Berlingo Multispace",
                IdMarca = 4,
                Versions = versions
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
                Cuil = "20-23456456-9",                
            };

            context.Persona.Add(persona);
            context.SaveChanges();
        }

        private static void CargarOrganizadorProductor(PolicyCenterContext context)
        {
            var productor = new Productor
            {
                Nombre = "Juan Valdez",
                Matricula = 654157
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

        private static void CargarRiesgos(PolicyCenterContext context)
        {
            var riesgos = new List<Riesgo>();
            var riesgo = new Riesgo
            {
                Nombre = "Responsabilidad ​civil"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Pérdida total por robo y/o hurto sin franquicia"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Seguro de Accidentes Personales, en caso de fallecimiento, por cada ocupante del vehículo"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Pérdida total por incendio sin franquicia"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Destrucción total por accidente"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Pérdida parcial por robo y/o hurto e incendio sin franquicia"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Rotura de cristales laterales del vehículo"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Rotura de luneta y parabrisas del vehículo por cualquier causa sin franquicia"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Rotura de cristales de techo del vehículo"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Daños parciales con franquicia"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Pérdida y/o Daños parciales como consecuencia de un robo/hurto total"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Rotura de cerraduras"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Daños parciales como consecuencia de granizo"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Daños parciales como consecuencia de inundación"
            };
            riesgos.Add(riesgo);

            riesgo = new Riesgo
            {
                Nombre = "Asistencia en viaje las 24 horas al vehículo"
            };
            riesgos.Add(riesgo);

            context.Riesgo.AddRange(riesgos);
            context.SaveChanges();
        }

        private static void CargarCoberturas(PolicyCenterContext context)
        {
            var cobertura = new Cobertura
            {
                Nombre = "A",
                Riesgos = context.Riesgo.Where(_ => _.IdRiesgo == 1).ToList()
            };

            context.Cobertura.Add(cobertura);

            //cobertura = new Cobertura
            //{
            //    Nombre = "B",
            //    Riesgos = context.Riesgo.Where(_ => _.IdRiesgo == 1 && _.IdRiesgo == 2).ToList()
            //};
            //context.Cobertura.Add(cobertura);

            cobertura = new Cobertura
            {
                Nombre = "C",
                Riesgos = context.Riesgo.Where(_ => _.IdRiesgo <= 4).ToList()
            };
            context.Cobertura.Add(cobertura);

            cobertura = new Cobertura
            {
                Nombre = "C+",
                Riesgos = context.Riesgo.Where(_ => _.IdRiesgo <= 8).ToList()
            };

            context.Cobertura.Add(cobertura);

            cobertura = new Cobertura
            {
                Nombre = "D",
                Riesgos = context.Riesgo.Where(_ => _.IdRiesgo <= 15).ToList()
            };

            context.Cobertura.Add(cobertura);

            context.SaveChanges();
        }

        private static void CargarRamos(PolicyCenterContext context)
        {
            var ramo = new Ramo { Nombre = "Automotores" };
            context.Ramo.Add(ramo);

            ramo = new Ramo { Nombre = "Combinado Familiar e Integral de Consorcio" };
            context.Ramo.Add(ramo);

            ramo = new Ramo { Nombre = "Granizo" };
            context.Ramo.Add(ramo);

            context.SaveChanges();
        }

        private static void CargarVehiculos(PolicyCenterContext context)
        {            

            /*
             *  
             *  select * 
                from Marca m inner join Modelo model on m.IdMarca = model.IdMarca
                inner join VersionModelo vm on model.IdModelo = vm.Modelo_IdModelo
                inner join Version v on v.IdVersion = vm.Version_IdVersion
                where m.IdMarca = 10
                and vm.Modelo_IdModelo = 10
                and vm.Version_IdVersion = 41
             *             
             */

            var vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 10).FirstOrDefault().IdMarca,  // VW
                IdVersion = context.Version.Where(_ => _.IdVersion == 41).FirstOrDefault().IdVersion, // Trendline Manual
                IdModelo = 10,  // Golf 1.6
                Precio = 406534M,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };
            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 10).FirstOrDefault().IdMarca,  // VW
                IdVersion = context.Version.Where(_ => _.IdVersion == 39).FirstOrDefault().IdVersion, // Comfortline manual
                IdModelo = 9,  // Golf 1.4 TSI
                Precio = 470184M,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };
            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 10).FirstOrDefault().IdMarca,  // VW
                IdVersion = context.Version.Where(_ => _.IdVersion == 38).FirstOrDefault().IdVersion, // Comfortline DSG
                IdModelo = 9,  // Golf 1.4 TSI
                Precio = 500769M,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };
            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 10).FirstOrDefault().IdMarca,  // VW
                IdVersion = context.Version.Where(_ => _.IdVersion == 40).FirstOrDefault().IdVersion, // Highline DSG
                IdModelo = 9,  // Golf 1.4 TSI
                Precio = 538934M,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };
            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 10).FirstOrDefault().IdMarca,  // VW
                IdVersion = context.Version.Where(_ => _.IdVersion == 42).FirstOrDefault().IdVersion, // GTI
                IdModelo = 11,  // GTI
                Precio = 45073M * 18,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };
            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 10).FirstOrDefault().IdMarca,  // VW
                IdVersion = context.Version.Where(_ => _.IdVersion == 43).FirstOrDefault().IdVersion, // GTI + App Connect
                IdModelo = 11,  // GTI
                Precio = 45200M * 18,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };
            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 10).FirstOrDefault().IdMarca,  // VW
                IdVersion = context.Version.Where(_ => _.IdVersion == 44).FirstOrDefault().IdVersion, // GTI + App Connect + Cuero
                IdModelo = 11,  // GTI
                Precio = 46862M * 18,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };
            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 10).FirstOrDefault().IdMarca,  // VW
                IdVersion = context.Version.Where(_ => _.IdVersion == 45).FirstOrDefault().IdVersion, // GTI MY15
                IdModelo = 11,  // GTI
                Precio = 46000M * 18,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };
            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 10).FirstOrDefault().IdMarca,  // VW
                IdVersion = context.Version.Where(_ => _.IdVersion == 46).FirstOrDefault().IdVersion, // GTI MY15 + Cuero
                IdModelo = 11,  // GTI
                Precio = 47500M * 18,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };
            context.Bien.Add(vehiculo);


            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 4).FirstOrDefault().IdMarca, //Citroen
                IdVersion = context.Version.Where(_ => _.IdVersion == 88).FirstOrDefault().IdVersion, //Live VTi
                IdModelo = 33, // C3
                Precio= 294500M,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };

            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 4).FirstOrDefault().IdMarca, //Citroen
                IdVersion = context.Version.Where(_ => _.IdVersion == 89).FirstOrDefault().IdVersion, //Feel VTi
                IdModelo = 33, // C3
                Precio = 343500M,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };

            context.Bien.Add(vehiculo);

            vehiculo = new Vehiculo
            {
                IdMarca = context.Marca.Where(_ => _.IdMarca == 4).FirstOrDefault().IdMarca, //Citroen
                IdVersion = context.Version.Where(_ => _.IdVersion == 91).FirstOrDefault().IdVersion, //Shine VTi
                IdModelo = 33, // C3
                Precio = 371500M,
                Anio = 2017,
                IdRamo = 1,
                Activo = true
            };

            context.Bien.Add(vehiculo);

            context.SaveChanges();
        }

        private static void CargarPolizas(PolicyCenterContext context)
        {
            var poliza = new Model.Poliza
            {
                IdPersona = 1,                
                IdProductor = 1,
                IdBien = 1,                
                IdCobertura = 1,
                VigenciaDesde = System.DateTime.Now,
                VigenciaHasta = System.DateTime.Now.AddDays(180),
                Estado = "Vigente",
                Premio = 2000,
                Prima = 1500,
                Guid = Guid.NewGuid().ToString()
            };            
            poliza.IdentificadorPoliza = poliza.IdProductor.ToString("0000000") + poliza.IdBien.ToString("0000000") + poliza.IdPersona.ToString("0000000");

            context.Poliza.Add(poliza);
            context.SaveChanges();
        }
    }
}