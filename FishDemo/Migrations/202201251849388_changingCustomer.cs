namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changingCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "PickUpStreet", c => c.String(maxLength: 255));
            AddColumn("dbo.CustomerModels", "PickUpCity", c => c.String(maxLength: 255));
            AddColumn("dbo.CustomerModels", "PickUpState", c => c.String(maxLength: 20));
            AddColumn("dbo.CustomerModels", "PickUpZip", c => c.String(maxLength: 255));
            DropColumn("dbo.RideModels", "PickUpStreet");
            DropColumn("dbo.RideModels", "PickUpCity");
            DropColumn("dbo.RideModels", "PickUpState");
            DropColumn("dbo.RideModels", "PickUpZip");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RideModels", "PickUpZip", c => c.String());
            AddColumn("dbo.RideModels", "PickUpState", c => c.String());
            AddColumn("dbo.RideModels", "PickUpCity", c => c.String());
            AddColumn("dbo.RideModels", "PickUpStreet", c => c.String());
            DropColumn("dbo.CustomerModels", "PickUpZip");
            DropColumn("dbo.CustomerModels", "PickUpState");
            DropColumn("dbo.CustomerModels", "PickUpCity");
            DropColumn("dbo.CustomerModels", "PickUpStreet");
        }
    }
}
