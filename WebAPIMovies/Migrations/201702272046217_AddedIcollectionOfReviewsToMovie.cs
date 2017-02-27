namespace WebAPIMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedIcollectionOfReviewsToMovie : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Movie_Id", c => c.Int());
            CreateIndex("dbo.Movies", "Movie_Id");
            AddForeignKey("dbo.Movies", "Movie_Id", "dbo.Movies", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "Movie_Id", "dbo.Movies");
            DropIndex("dbo.Movies", new[] { "Movie_Id" });
            DropColumn("dbo.Movies", "Movie_Id");
        }
    }
}
