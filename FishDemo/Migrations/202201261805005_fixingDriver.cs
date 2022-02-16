namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingDriver : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RideModels", "Status", c => c.Int(nullable: false));
            DropColumn("dbo.DriverModels", "DatesAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DriverModels", "DatesAvailable", c => c.String());
            DropColumn("dbo.RideModels", "Status");
        }
    }
}
