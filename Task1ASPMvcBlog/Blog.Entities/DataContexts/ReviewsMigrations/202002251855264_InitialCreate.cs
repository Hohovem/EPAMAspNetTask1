namespace Blog.Entities.DataContexts.ReviewsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Reviews", "AuthorNameTest", "AtoTe");
        }
    }
}
