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
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Marca>().HasKey(_ => _.IdMarca);
            modelBuilder.Entity<Modelo>()
                .HasKey(_ => _.IdModelo)
                .HasRequired(_ => _.Versions);
            modelBuilder.Entity<Version>()
                .HasKey(_ => _.IdVersion)
                .HasRequired(_ => _.Modelo).WithMany(_ => _.Versions)
                .HasForeignKey(_ => _.IdModelo);

            modelBuilder.Entity<Localidad>().HasKey(_ => _.IdLocalidad);
            modelBuilder.Entity<Vehiculo>().HasKey(_ => _.IdVehiculo);
          
            modelBuilder.Entity<Persona>().HasKey(_ => _.IdPersona)
                .HasRequired(_ => _.Localidad);

            modelBuilder.Entity<Persona>().HasRequired(_ => _.Direccion);
            modelBuilder.Entity<Direccion>().HasKey(_ => _.IdDireccion);
        }

        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public Version Version { get; set; }
        public Localidad Localidad { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Persona Persona { get; set; }


    }
}
