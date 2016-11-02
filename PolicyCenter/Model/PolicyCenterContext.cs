using System.Data.Entity;
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
                .HasMany(_ => _.Models).WithMany(_ => _.Versions);                

            modelBuilder.Entity<Localidad>().HasKey(_ => _.IdLocalidad);
            modelBuilder.Entity<Vehiculo>().HasKey(_ => _.IdVehiculo);
          
            modelBuilder.Entity<Persona>().HasKey(_ => _.IdPersona)
                .HasRequired(_ => _.Localidad);

            modelBuilder.Entity<Persona>().HasRequired(_ => _.Direccion);
            modelBuilder.Entity<Direccion>().HasKey(_ => _.IdDireccion);

            modelBuilder.Entity<Productor>().HasKey(_ => _.IdProductor);
            modelBuilder.Entity<Organizador>().HasKey(_ => _.IdOrganizador).HasMany(_ => _.Productores);
        }

        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<Version> Version { get; set; }
        public DbSet<Localidad> Localidad { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Productor> Productor { get; set; }
        public DbSet<Organizador> Organizador { get; set; }


    }
}
