namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Genres (Id, GenreName) VALUES (1, 'Comedy')");
            Sql("Insert INTO Genres (Id, GenreName) VALUES (2, 'Action')");
            Sql("Insert INTO Genres (Id, GenreName) VALUES (3, 'Family')");
            Sql("Insert INTO Genres (Id, GenreName) VALUES (4, 'Romance')");
            Sql("Insert INTO Genres (Id, GenreName) VALUES (5, 'Sci fi')");
            Sql("Insert INTO Genres (Id, GenreName) VALUES (6, 'Horror')");
            Sql("Insert INTO Genres (Id, GenreName) VALUES (7, 'Thriller')");
            Sql("Insert INTO Genres (Id, GenreName) VALUES (8, 'Drama')");
            Sql("Insert INTO Genres (Id, GenreName) VALUES (9, 'Mystery')");
        }

        public override void Down()
        {
        }
    }
}
