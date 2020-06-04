namespace CodeFirst.ExerciseData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyModelsUsingFluentAPI : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Videos", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "Name", c => c.String());
            AlterColumn("dbo.Genres", "Name", c => c.String());
            DropColumn("dbo.Videos", "GenreId");
        }
    }
}
