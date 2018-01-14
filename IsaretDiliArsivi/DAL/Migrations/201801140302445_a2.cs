namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories Details", "GifName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryName", c => c.String(nullable: false, maxLength: 20));
            AlterColumn("dbo.Categories Details", "GifName", c => c.String(nullable: false, maxLength: 20));
        }
    }
}
