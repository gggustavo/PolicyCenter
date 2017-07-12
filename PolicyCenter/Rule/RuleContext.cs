using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace Rule
{
    public class RuleContext : DbContext
    {
        public RuleContext() : base("name=Rules")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Database.SetInitializer(new ContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Entidades.AntiguedadRiesgo>().HasKey(_ => _.Id);

            modelBuilder.Entity<Entidades.AntiguedadRiesgo>().Property(_ => _.Valor).HasPrecision(16, 3);

            modelBuilder.Entity<Entidades.UbicacionRiesgo>().HasKey(_ => _.Id);
            modelBuilder.Entity<Entidades.UbicacionRiesgo>().Property(_ => _.Valor).HasPrecision(16, 4);
        }


        public DbSet<Entidades.AntiguedadRiesgo> AntiguedadRiesgo { get; set; }
        public DbSet<Entidades.UbicacionRiesgo> UbicacionRiesgo { get; set; }

    }
}
