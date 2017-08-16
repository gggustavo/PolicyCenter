using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Rule
{
    public class ContextInitializer : DropCreateDatabaseIfModelChanges<RuleContext>
    {
        protected override void Seed(RuleContext context)
        {
            CargarAntiguedadRiesgo(context);
            CargarUbicacionRiesgo(context);

            base.Seed(context);
        }

        private static void CargarAntiguedadRiesgo(RuleContext context)
        {
            var antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2017,
                Valor = Convert.ToDecimal(0.001)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);
            context.SaveChanges();


            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2016,
                Valor = Convert.ToDecimal(0.004)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();

            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2015,
                Valor = Convert.ToDecimal(0.006)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();

            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2014,
                Valor = Convert.ToDecimal(0.008)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();

            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2013,
                Valor = Convert.ToDecimal(0.010)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();

            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2012,
                Valor = Convert.ToDecimal(0.012)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();

            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2011,
                Valor = Convert.ToDecimal(0.014)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();

            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2010,
                Valor = Convert.ToDecimal(0.016)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();

            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2009,
                Valor = Convert.ToDecimal(0.018)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();


            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2008,
                Valor = Convert.ToDecimal(0.020)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();


            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2007,
                Valor = Convert.ToDecimal(0.022)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();


            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2006,
                Valor = Convert.ToDecimal(0.024)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();


            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2005,
                Valor = Convert.ToDecimal(0.026)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();


            antiguedadRiesgo = new Entidades.AntiguedadRiesgo
            {
                Modelo = 2004,
                Valor = Convert.ToDecimal(0.028)
            };

            context.AntiguedadRiesgo.Add(antiguedadRiesgo);

            context.SaveChanges();
        }

        private static void CargarUbicacionRiesgo(RuleContext context)
        {
            var ubicacionRiesgo = new Entidades.UbicacionRiesgo
            {
                Ciudad = "Capital Federal",
                CodigoPostal = 1000,
                Valor = Convert.ToDecimal(0.005)
            };

            context.UbicacionRiesgo.Add(ubicacionRiesgo);
            context.SaveChanges();

            ubicacionRiesgo = new Entidades.UbicacionRiesgo
            {
                Ciudad = "Rosario",
                CodigoPostal = 2000,
                Valor = Convert.ToDecimal(0.002)
            };

            context.UbicacionRiesgo.Add(ubicacionRiesgo);
            context.SaveChanges();

            ubicacionRiesgo = new Entidades.UbicacionRiesgo
            {
                CodigoPostal = 2000,
                Ciudad = "Funes",
                Valor = Convert.ToDecimal(0.0015)
            };

            context.UbicacionRiesgo.Add(ubicacionRiesgo);
            context.SaveChanges();

            ubicacionRiesgo = new Entidades.UbicacionRiesgo
            {
                CodigoPostal = 2170,
                Ciudad = "Casilda",
                Valor = Convert.ToDecimal(0.009)
            };

            context.UbicacionRiesgo.Add(ubicacionRiesgo);
            context.SaveChanges();

        }
    }
}
