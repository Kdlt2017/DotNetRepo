namespace MyFinance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TPHMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "IsBiological", c => c.Int());
            DropColumn("dbo.Products", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Products", "IsBiological");
        }
    }
}
