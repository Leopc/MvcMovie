namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModelValidation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MovieModels",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(nullable: false),
                        Rating = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            DropTable("dbo.Movies");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Rating = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            DropTable("dbo.UserProfile");
            DropTable("dbo.MovieModels");
        }
    }
}
