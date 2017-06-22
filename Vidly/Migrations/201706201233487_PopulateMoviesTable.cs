namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesTable : DbMigration
    {
        public override void Up()
        {
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('Hangover', '1972-05-04', '2017-06-20' , 10 , 1)");
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('Die Hard', '1972-05-04', '2017-06-20' , 10 , 2)");
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('The Terminator', '1972-05-04', '2017-06-20' , 10 , 2)");
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('Toy Story', '1972-05-04', '2017-06-20' , 10 , 3)");
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('Titanic', '1972-05-04', '2017-06-20' , 10 , 4)");
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('Lego Batman', '1972-05-04', '2017-06-20' , 10 , 3)");
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('Iron man', '1972-05-04', '2017-06-20' , 10 , 2)");
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('The Avengers: Civil War', '1972-05-04', '2017-06-20' , 10 , 2)");
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('Friday the 13th', '1972-05-04', '2017-06-20' , 10 , 6)");
            Sql("Insert INTO Movies (Name , ReleaseDate , DateAdded , NumberInStock, GenreId) VALUES ('The Color Purple', '1972-05-04', '2017-06-20' , 10 , 8)");
        }

        public override void Down()
        {
        }
    }
}
