namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class driver1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.DriverModels", "FirstName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DriverModels", "LastName", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DriverModels", "DateOfBirth", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DriverModels", "LicenseNumber", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.DriverModels", "Phone", c => c.String(nullable: false, maxLength: 255));
            DropColumn("dbo.DriverModels", "Email");
            DropColumn("dbo.DriverModels", "Password");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DriverModels", "Password", c => c.String());
            AddColumn("dbo.DriverModels", "Email", c => c.String());
            AlterColumn("dbo.DriverModels", "Phone", c => c.String());
            AlterColumn("dbo.DriverModels", "LicenseNumber", c => c.Int(nullable: false));
            AlterColumn("dbo.DriverModels", "DateOfBirth", c => c.String());
            AlterColumn("dbo.DriverModels", "LastName", c => c.String());
            AlterColumn("dbo.DriverModels", "FirstName", c => c.String());
        }
    }
}
