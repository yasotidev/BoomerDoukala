using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using Doukala.Server.Core.Entities;

namespace Doukala.Server.Core.Data
{
    public class DataContext<TContext> : DbContext, IDataContext where TContext : DbContext
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

        public ObjectContext ObjectContext()
        {
            return (this as IObjectContextAdapter).ObjectContext;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DefaultContext>());
        }


        public virtual IDbSet<T> DbSet<T>() where T : DomainObject
        {
            return Set<T>();
        }

        public new DbEntityEntry Entry<T>(T entity) where T : DomainObject
        {
            return base.Entry(entity);
        }
    }
}