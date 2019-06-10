namespace Lab7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "GenreId", c => c.Int(nullable: false));
            DropColumn("dbo.Songs", "Genre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Songs", "Genre", c => c.String());
            DropColumn("dbo.Songs", "GenreId");
        }
    }
}
