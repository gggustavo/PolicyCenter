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


        }

        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public Version Version { get; set; }
        public Anio Anio { get; set; }


    }
}
