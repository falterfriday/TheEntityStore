namespace TheEntityStore.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class PopulateCategoriesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (Id, Name) VALUES (1, 'Household')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (2, 'Personal Care')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (3, 'Home & Kitchen')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (4, 'Clothing')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (5, 'Jewelry')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (6, 'Electronics')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (7, 'Gardening')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (8, 'Tools')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (9, 'Sports')");
            Sql("INSERT INTO Categories (Id, Name) VALUES (10, 'Books')");
        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id IN (1,2,3,4,5,6,7,8,9,10)");
        }
    }
}
