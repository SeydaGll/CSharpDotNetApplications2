namespace WinFormEFex.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WinFormEFex.WinformDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;  // otomatik migrationlarý açtýk
            AutomaticMigrationDataLossAllowed = true; // otomatik migrationda data kaybýný kabul ediyomusun ? true dedik
            // böyle yaparsak database deðiþtirdiðim zaman hata vericek.. o yüzden datacontext kýsmýnda base altýnda bir strateji yazdýk!!!
        }

        protected override void Seed(WinFormEFex.WinformDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
