namespace GigHub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManqueColonnes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Artiste_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Gigs", new[] { "Artiste_Id" });
            AddColumn("dbo.Gigs", "Genre_GenreID", c => c.Byte());
            AlterColumn("dbo.Gigs", "Artiste_Id", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Gigs", "Artiste_Id");
            CreateIndex("dbo.Gigs", "Genre_GenreID");
            AddForeignKey("dbo.Gigs", "Genre_GenreID", "dbo.Genres", "GenreID");
            AddForeignKey("dbo.Gigs", "Artiste_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Artiste_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Gigs", "Genre_GenreID", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_GenreID" });
            DropIndex("dbo.Gigs", new[] { "Artiste_Id" });
            AlterColumn("dbo.Gigs", "Artiste_Id", c => c.String(maxLength: 128));
            DropColumn("dbo.Gigs", "Genre_GenreID");
            CreateIndex("dbo.Gigs", "Artiste_Id");
            AddForeignKey("dbo.Gigs", "Artiste_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
