namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories Details",
                c => new
                    {
                        GifNames_ID = c.Int(nullable: false, identity: true),
                        GifName = c.String(nullable: false, maxLength: 20),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GifNames_ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories Details", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Categories Details", new[] { "CategoryID" });
            DropTable("dbo.Categories");
            DropTable("dbo.Categories Details");
        }
    }
}
