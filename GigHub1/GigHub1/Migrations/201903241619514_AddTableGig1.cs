namespace GigHub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTableGig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        GenreID = c.Byte(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.Gigs",
                c => new
                    {
                        id = c.Byte(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                        Venue = c.String(),
                        Artiste_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.AspNetUsers", t => t.Artiste_Id)
                .Index(t => t.Artiste_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Artiste_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "Artiste_Id" });
            DropTable("dbo.Gigs");
            DropTable("dbo.Genres");
        }
    }
}
