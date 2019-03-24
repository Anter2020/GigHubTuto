namespace GigHub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ouverrideConventionforgigsandgennrs : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Gigs", "Genre_GenreID", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_GenreID" });
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Gigs", "Venue", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Gigs", "Genre_GenreID", c => c.Byte(nullable: false));
            CreateIndex("dbo.Gigs", "Genre_GenreID");
            AddForeignKey("dbo.Gigs", "Genre_GenreID", "dbo.Genres", "GenreID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gigs", "Genre_GenreID", "dbo.Genres");
            DropIndex("dbo.Gigs", new[] { "Genre_GenreID" });
            AlterColumn("dbo.Gigs", "Genre_GenreID", c => c.Byte());
            AlterColumn("dbo.Gigs", "Venue", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            CreateIndex("dbo.Gigs", "Genre_GenreID");
            AddForeignKey("dbo.Gigs", "Genre_GenreID", "dbo.Genres", "GenreID");
        }
    }
}
