namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondImageMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageUrl2", c => c.String());
            DropColumn("dbo.Products", "ImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ImageUrl", c => c.String());
            DropColumn("dbo.Products", "ImageUrl2");
        }
    }
}
