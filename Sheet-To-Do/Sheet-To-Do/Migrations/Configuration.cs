namespace Sheet_To_Do.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Sheet_To_Do.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Sheet_To_Do.Models.SheetToDoContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "Sheet_To_Do.Models.SheetToDoContext";
        }

        protected override void Seed(Sheet_To_Do.Models.SheetToDoContext context)
        {
                context.Tasks.AddOrUpdate(
                  new Task("Go to codecool" ),
                  new Task("Buy some milk"),
                  new Task("Go to movie"),
                  new Task("Create over app")
                );

        }
    }
}
