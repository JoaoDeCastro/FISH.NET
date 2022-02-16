namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class driver : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DriverModels", "RideId", "dbo.RideModels");
            DropIndex("dbo.DriverModels", new[] { "RideId" });
            RenameColumn(table: "dbo.DriverModels", name: "RideId", newName: "Ride_RideId");
            AlterColumn("dbo.DriverModels", "Ride_RideId", c => c.Int());
            CreateIndex("dbo.DriverModels", "Ride_RideId");
            AddForeignKey("dbo.DriverModels", "Ride_RideId", "dbo.RideModels", "RideId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DriverModels", "Ride_RideId", "dbo.RideModels");
            DropIndex("dbo.DriverModels", new[] { "Ride_RideId" });
            AlterColumn("dbo.DriverModels", "Ride_RideId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.DriverModels", name: "Ride_RideId", newName: "RideId");
            CreateIndex("dbo.DriverModels", "RideId");
            AddForeignKey("dbo.DriverModels", "RideId", "dbo.RideModels", "RideId", cascadeDelete: true);
        }
    }
}
