namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zip : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CustomerModels", "PickUpZip", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            DropColumn("dbo.CustomerModels", "PickUpZip");
        }
    }
}
