﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Rule;

namespace TestPolicyCenter
{
    [TestClass]
    public class UbicacionRiesgo
    {

        [TestMethod]
        public void CalculatePrimaCoberturaCRosario()
        {
            var poliza = new Poliza
            {
                IdPersona = 1,
                Persona = new Persona { Localidad = new Localidad { CodPostal = 2000, Nombre = "Rosario"} },
                IdProductor = 1,
                IdBien = 1,
                Bien = new Vehiculo
                {
                    Precio = 350000M,
                    Anio = 2017
                },
                IdCobertura = 2,
                IdentificadorPoliza = "1",
                VigenciaDesde = System.DateTime.Now,
                VigenciaHasta = System.DateTime.Now.AddDays(180),
                Estado = "Vigente"
            };

            var rules = new ReglasPoliza(poliza);
            poliza.Prima = rules.CalcularPrima();
            Console.WriteLine("Prima: " + poliza.Prima);
            Assert.IsTrue(poliza.Prima > 0);

            poliza.Premio = rules.CalcularPremio(poliza.Prima);
            Console.WriteLine("Premio: " + poliza.Premio);
            Assert.IsTrue(poliza.Premio > 0);
        }

        [TestMethod]
        public void CalculatePrimaCoberturaCBuenosAires()
        {
            var poliza = new Poliza
            {
                IdPersona = 1,
                Persona = new Persona { Localidad = new Localidad { CodPostal = 1000, Nombre = "BuenosAires" } },
                IdProductor = 1,
                IdBien = 1,
                Bien = new Vehiculo
                {
                    Precio = 350000M,
                    Anio = 2017
                },
                IdCobertura = 2,
                IdentificadorPoliza = "1",
                VigenciaDesde = System.DateTime.Now,
                VigenciaHasta = System.DateTime.Now.AddDays(180),
                Estado = "Vigente"
            };

            var rules = new ReglasPoliza(poliza);
            poliza.Prima = rules.CalcularPrima();
            Console.WriteLine("Prima: " + poliza.Prima);
            Assert.IsTrue(poliza.Prima > 0);

            poliza.Premio = rules.CalcularPremio(poliza.Prima);
            Console.WriteLine("Premio: " + poliza.Premio);
            Assert.IsTrue(poliza.Premio > 0);
        }



    }
}
