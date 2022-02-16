namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class forinKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.CustomerModels", "RideId", "dbo.RideModels");
            DropIndex("dbo.CustomerModels", new[] { "RideId" });
            RenameColumn(table: "dbo.CustomerModels", name: "RideId", newName: "ride_RideId");
            AlterColumn("dbo.CustomerModels", "ride_RideId", c => c.Int());
            CreateIndex("dbo.CustomerModels", "ride_RideId");
            AddForeignKey("dbo.CustomerModels", "ride_RideId", "dbo.RideModels", "RideId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerModels", "ride_RideId", "dbo.RideModels");
            DropIndex("dbo.CustomerModels", new[] { "ride_RideId" });
            AlterColumn("dbo.CustomerModels", "ride_RideId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.CustomerModels", name: "ride_RideId", newName: "RideId");
            CreateIndex("dbo.CustomerModels", "RideId");
            AddForeignKey("dbo.CustomerModels", "RideId", "dbo.RideModels", "RideId", cascadeDelete: true);
        }
    }
}
