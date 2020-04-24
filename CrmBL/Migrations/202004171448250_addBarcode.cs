namespace CrmBL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addBarcode : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Barcode", c => c.String());
            AddColumn("dbo.Products", "Rating", c => c.Decimal(nullable: false, precision: 4, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "Rating");
            DropColumn("dbo.Products", "Barcode");
        }
    }
}
