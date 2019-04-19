namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManyToManyMigration2 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ProviderProducts", newName: "Providings");
            RenameColumn(table: "dbo.Providings", name: "Provider_Id", newName: "Product");
            RenameColumn(table: "dbo.Providings", name: "Product_ProductId", newName: "Provider");
            RenameIndex(table: "dbo.Providings", name: "IX_Product_ProductId", newName: "IX_Provider");
            RenameIndex(table: "dbo.Providings", name: "IX_Provider_Id", newName: "IX_Product");
            DropPrimaryKey("dbo.Providings");
            AddPrimaryKey("dbo.Providings", new[] { "Provider", "Product" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Providings");
            AddPrimaryKey("dbo.Providings", new[] { "Provider_Id", "Product_ProductId" });
            RenameIndex(table: "dbo.Providings", name: "IX_Product", newName: "IX_Provider_Id");
            RenameIndex(table: "dbo.Providings", name: "IX_Provider", newName: "IX_Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "Provider", newName: "Product_ProductId");
            RenameColumn(table: "dbo.Providings", name: "Product", newName: "Provider_Id");
            RenameTable(name: "dbo.Providings", newName: "ProviderProducts");
        }
    }
}
