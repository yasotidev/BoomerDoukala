using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

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
    }
}