namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ComplexTypeMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ImageUrl", c => c.String());
            AddColumn("dbo.Products", "Address_City", c => c.String());
            AddColumn("dbo.Products", "Address_StreetAddress", c => c.String());
            DropColumn("dbo.Products", "ImageUrl2");
            DropColumn("dbo.Products", "City");
            DropColumn("dbo.Products", "StreetAddress");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "StreetAddress", c => c.String());
            AddColumn("dbo.Products", "City", c => c.String());
            AddColumn("dbo.Products", "ImageUrl2", c => c.String());
            DropColumn("dbo.Products", "Address_StreetAddress");
            DropColumn("dbo.Products", "Address_City");
            DropColumn("dbo.Products", "ImageUrl");
        }
    }
}
