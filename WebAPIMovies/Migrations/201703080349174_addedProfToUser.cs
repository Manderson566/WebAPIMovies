namespace WebAPIMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedProfToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Profession", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Profession");
        }
    }
}
