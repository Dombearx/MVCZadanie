namespace Lab7.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Songs", "Name", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Songs", "Artist", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Songs", "GenreId");
            AddForeignKey("dbo.Songs", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "GenreId", "dbo.Genres");
            DropIndex("dbo.Songs", new[] { "GenreId" });
            AlterColumn("dbo.Songs", "Artist", c => c.String());
            AlterColumn("dbo.Songs", "Name", c => c.String());
            DropTable("dbo.Genres");
        }
    }
}
