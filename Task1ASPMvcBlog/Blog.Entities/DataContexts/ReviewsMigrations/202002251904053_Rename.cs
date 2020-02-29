namespace Blog.Entities.DataContexts.ReviewsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rename : DbMigration
    {
        public override void Up()
        {
            RenameColumn("dbo.Reviews", "AuthorNameTest", "Test");
        }
        
        public override void Down()
        {
            RenameColumn("dbo.Reviews", "AuthorNameTest", "Test");
        }
    }
}
