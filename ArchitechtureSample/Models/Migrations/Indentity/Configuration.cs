using System.Data.Entity.Migrations;
using FloraLimitedTest.Models.Context;

namespace FloraLimitedTest.Models.Migrations.Indentity {
    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Models\Migrations\Indentity";
        }

        protected override void Seed(ApplicationDbContext context) {
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