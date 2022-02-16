namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixingCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "EmergencyContact", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "EmergencyContact");
        }
    }
}
