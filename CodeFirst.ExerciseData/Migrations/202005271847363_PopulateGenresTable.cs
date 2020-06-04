namespace CodeFirst.ExerciseData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO GENRES VALUES(1, 'Comedy')");
            Sql("INSERT INTO GENRES VALUES(2, 'Action')");
            Sql("INSERT INTO GENRES VALUES(3, 'Thriller')");
            Sql("INSERT INTO GENRES VALUES(4, 'Horror')");
        }
        
        public override void Down()
        {
            Sql("Delete FROM GENRES");
        }
    }
}
