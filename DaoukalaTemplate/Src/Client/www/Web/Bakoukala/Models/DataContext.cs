using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Bakoukala.Models
{
    public class DataContext<TContext> : DbContext where TContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer<TContext>(null);
        }

        public DataContext(bool proxyCreation = true)
            :base("name=Doukala")
        {
            Configuration.ProxyCreationEnabled = proxyCreation;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}