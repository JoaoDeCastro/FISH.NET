namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class test : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CustomerModels", "PickUpZip");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CustomerModels", "PickUpZip", c => c.String(maxLength: 255));
        }
    }
}
