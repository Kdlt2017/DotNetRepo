namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FluentAPIConfigurationMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Categories", newName: "MyCategories");
            AlterColumn("dbo.MyCategories", "Name", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.MyCategories", "Name", c => c.String());
            RenameTable(name: "dbo.MyCategories", newName: "Categories");
        }
    }
}
