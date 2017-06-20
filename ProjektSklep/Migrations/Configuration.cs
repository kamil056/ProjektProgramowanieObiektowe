using ProjektSklep.DAL;

namespace ProjektSklep.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<ProjektSklep.DAL.ProduktyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "ProjektSklep.DAL.ProduktyContext";
        }

        protected override void Seed(ProjektSklep.DAL.ProduktyContext context)
        {
            ProduktyInitializer.SeedProduktyData(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
