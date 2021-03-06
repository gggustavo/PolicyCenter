﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Model
{
    public class PolicyCenterContext : DbContext
    {
        public PolicyCenterContext() : base("name=Default")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new ContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Marca>().HasKey(_ => _.IdMarca);

            modelBuilder.Entity<Modelo>()
                .HasKey(_ => _.IdModelo);

            modelBuilder.Entity<Version>()
                .HasKey(_ => _.IdVersion)
                .HasMany(_ => _.Models)
                .WithMany(_ => _.Versions);                

            modelBuilder.Entity<Localidad>().HasKey(_ => _.IdLocalidad);

            modelBuilder.Entity<Vehiculo>().HasRequired(_ => _.Marca);
            modelBuilder.Entity<Vehiculo>().HasRequired(_ => _.Modelo);
            modelBuilder.Entity<Vehiculo>().HasRequired(_ => _.Version);
          
            modelBuilder.Entity<Persona>()
                .HasKey(_ => _.IdPersona)
                .HasRequired(_ => _.Localidad);

            modelBuilder.Entity<Persona>().HasRequired(_ => _.Direccion);
            modelBuilder.Entity<Direccion>().HasKey(_ => _.IdDireccion);

            modelBuilder.Entity<Productor>().HasKey(_ => _.IdProductor);

            modelBuilder.Entity<Organizador>()
                .HasKey(_ => _.IdOrganizador)
                .HasRequired(_ => _.Productores);

            modelBuilder.Entity<Cobertura>().HasKey(_ => _.IdCobertura);
            modelBuilder.Entity<Riesgo>().HasKey(_ => _.IdRiesgo);

            modelBuilder.Entity<Cobertura>()
                .HasMany(_ => _.Riesgos)
                .WithMany(_ => _.Coberturas);
         
            modelBuilder.Entity<Poliza>().HasKey(_ => _.IdPoliza);

            modelBuilder.Entity<Poliza>().HasRequired(_ => _.Persona);          
            modelBuilder.Entity<Poliza>().HasRequired(_ => _.Productor);
            modelBuilder.Entity<Poliza>().HasRequired(_ => _.Bien);
            modelBuilder.Entity<Poliza>().HasRequired(_ => _.Cobertura);

            modelBuilder.Entity<Bien>().HasKey(_ => _.IdBien);
            modelBuilder.Entity<Bien>().HasRequired(_ => _.Ramo);
            
            modelBuilder.Entity<Ramo>().HasKey(_ => _.IdRamo);
            
            modelBuilder.Entity<Vehiculo>().HasKey(_ => _.IdBien);
            modelBuilder.Entity<Vehiculo>().ToTable("BienVehiculo");

            modelBuilder.Entity<HistoriaBien>().HasKey(_ => _.Id).HasRequired(_ => _.Bien);            
        }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Version> Version { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Bien> Bien { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Productor> Productor { get; set; }
        public DbSet<Organizador> Organizador { get; set; }
        public DbSet<Poliza> Poliza { get; set; }
        public DbSet<Ramo> Ramo { get; set; }
        public DbSet<Riesgo> Riesgo { get; set; }
        public DbSet<Cobertura> Cobertura { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<HistoriaBien> HistoriaBien { get; set; }

    }
}
