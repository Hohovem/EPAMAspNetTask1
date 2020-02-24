namespace Blog.Entities.DataContexts.ReviewsMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReviewsDbContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        AuthorName = c.String(maxLength: 20),
                        Content = c.String(),
                        CreatedTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Reviews");
        }
    }
}
