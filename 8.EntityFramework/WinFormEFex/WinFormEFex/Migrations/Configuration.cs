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
            AutomaticMigrationsEnabled = true;  // otomatik migrationlar� a�t�k
            AutomaticMigrationDataLossAllowed = true; // otomatik migrationda data kayb�n� kabul ediyomusun ? true dedik
            // b�yle yaparsak database de�i�tirdi�im zaman hata vericek.. o y�zden datacontext k�sm�nda base alt�nda bir strateji yazd�k!!!
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
