namespace CrmBL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcolumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String());
            AddColumn("dbo.Marks", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Marks", "Description");
            DropColumn("dbo.Products", "Description");
        }
    }
}
