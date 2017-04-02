namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenres : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Discribe) VALUES (1, 'Komedy')");
            Sql("INSERT INTO Genres (Id, Discribe) VALUES (2, 'Drama')");
            Sql("INSERT INTO Genres (Id, Discribe) VALUES (3, 'Horror')");
            Sql("INSERT INTO Genres (Id, Discribe) VALUES (4, 'Western')");
        }
        
        public override void Down()
        {
        }
    }
}
