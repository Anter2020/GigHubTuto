namespace GigHub1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres (GenreID,Name) Values ('1','Jazz')");
            Sql("Insert Into Genres (GenreID,Name) Values ('2','Blues')");
            Sql("Insert Into Genres (GenreID,Name) Values ('3','Rock')");
            Sql("Insert Into Genres (GenreID,Name) Values ('4','Cha3bi')");
            Sql("Insert Into Genres (GenreID,Name) Values ('5','Mezwed')");
        }
        
        public override void Down()
        {
            Sql("Delete from Genres where GenreID in (1,2,3,4,5)");
        }
    }
}
