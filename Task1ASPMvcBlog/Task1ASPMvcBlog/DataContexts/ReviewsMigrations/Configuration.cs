namespace Task1ASPMvcBlog.DataContexts.ReviewsMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Task1ASPMvcBlog.DataContexts.ReviewsDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContexts\ReviewsMigrations";
            ContextKey = "Task1ASPMvcBlog.DataContexts.ReviewsDb";
        }

        protected override void Seed(Task1ASPMvcBlog.DataContexts.ReviewsDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
