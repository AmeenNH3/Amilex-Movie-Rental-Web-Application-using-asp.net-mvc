namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using System.Web.Mvc.Ajax;

    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {

            Sql("INSERT INTO Genres (Id, Name) VALUES (1,'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2,'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3,'Horror')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4,'Family')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5,'Action')");
            


        }

        public override void Down()
        {
        }
    }
}
