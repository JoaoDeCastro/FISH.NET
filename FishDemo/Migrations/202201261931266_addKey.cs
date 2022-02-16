namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerModels", "ride_RideId", "dbo.RideModels");
            DropIndex("dbo.CustomerModels", new[] { "ride_RideId" });
            RenameColumn(table: "dbo.CustomerModels", name: "ride_RideId", newName: "RideId");
            AlterColumn("dbo.CustomerModels", "RideId", c => c.Int(nullable: true));
            CreateIndex("dbo.CustomerModels", "RideId");
            AddForeignKey("dbo.CustomerModels", "RideId", "dbo.RideModels", "RideId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerModels", "RideId", "dbo.RideModels");
            DropIndex("dbo.CustomerModels", new[] { "RideId" });
            AlterColumn("dbo.CustomerModels", "RideId", c => c.Int());
            RenameColumn(table: "dbo.CustomerModels", name: "RideId", newName: "ride_RideId");
            CreateIndex("dbo.CustomerModels", "ride_RideId");
            AddForeignKey("dbo.CustomerModels", "ride_RideId", "dbo.RideModels", "RideId");
        }
    }
}
