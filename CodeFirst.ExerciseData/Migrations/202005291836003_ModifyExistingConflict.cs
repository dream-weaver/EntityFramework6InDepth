namespace CodeFirst.ExerciseData.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyExistingConflict : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Videos", new[] { "Genre_Id" });
            DropColumn("dbo.Videos", "GenreId");
            RenameColumn(table: "dbo.Videos", name: "Genre_Id", newName: "GenreId");
            AlterColumn("dbo.Videos", "GenreId", c => c.Byte(nullable: false));
            AlterColumn("dbo.Videos", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Videos", "GenreId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Videos", new[] { "GenreId" });
            AlterColumn("dbo.Videos", "GenreId", c => c.Byte());
            AlterColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Videos", name: "GenreId", newName: "Genre_Id");
            AddColumn("dbo.Videos", "GenreId", c => c.Int(nullable: false));
            CreateIndex("dbo.Videos", "Genre_Id");
        }
    }
}
