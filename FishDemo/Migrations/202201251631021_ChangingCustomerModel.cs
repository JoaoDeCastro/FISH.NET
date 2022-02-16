namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingCustomerModel : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CustomerModels", "Street");
            DropColumn("dbo.CustomerModels", "City");
            DropColumn("dbo.CustomerModels", "State");
            DropColumn("dbo.CustomerModels", "ZipCode");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerModels", "ZipCode", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.CustomerModels", "State", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.CustomerModels", "City", c => c.String(nullable: false, maxLength: 255));
            AddColumn("dbo.CustomerModels", "Street", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
