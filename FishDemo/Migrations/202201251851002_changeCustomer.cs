namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerModels", "PickUpStreet", c => c.String(nullable: true, maxLength: 255));
            AlterColumn("dbo.CustomerModels", "PickUpCity", c => c.String(nullable: true, maxLength: 255));
            AlterColumn("dbo.CustomerModels", "PickUpState", c => c.String(nullable: true, maxLength: 20));
            AlterColumn("dbo.CustomerModels", "PickUpZip", c => c.String(nullable: true, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerModels", "PickUpZip", c => c.String(maxLength: 255));
            AlterColumn("dbo.CustomerModels", "PickUpState", c => c.String(maxLength: 20));
            AlterColumn("dbo.CustomerModels", "PickUpCity", c => c.String(maxLength: 255));
            AlterColumn("dbo.CustomerModels", "PickUpStreet", c => c.String(maxLength: 255));
        }
    }
}
