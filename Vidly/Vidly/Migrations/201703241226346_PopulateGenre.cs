namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Discribe) VALUES (1, 'Komedy')");
            Sql("INSERT INTO Genres (Id, Discribe) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, Discribe) VALUES (3, 'Horror')");

        }

        public override void Down()
        {
        }
    }
}
