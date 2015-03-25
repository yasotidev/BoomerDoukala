using System.Data.Entity.Migrations;
using Doukala.Server.Core.Data.Seeders;

namespace Doukala.Server.Core.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DefaultContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DefaultContext context)
        {
            AppDataSeeder.Seed(context);
        }
    }
}
