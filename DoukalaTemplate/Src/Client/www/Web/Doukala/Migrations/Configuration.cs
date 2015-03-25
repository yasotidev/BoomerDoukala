using Doukala.Models;

namespace Doukala.Migrations
{
    using System.Data.Entity.Migrations;

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
