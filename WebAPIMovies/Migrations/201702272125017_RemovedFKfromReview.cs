namespace WebAPIMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedFKfromReview : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Reviews", "UserId", "dbo.Users");
            DropIndex("dbo.Reviews", new[] { "UserId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.Reviews", "UserId");
            AddForeignKey("dbo.Reviews", "UserId", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
