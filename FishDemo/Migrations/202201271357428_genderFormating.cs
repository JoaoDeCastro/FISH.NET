namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class genderFormating : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CustomerModels", "Gender", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CustomerModels", "Gender", c => c.String(maxLength: 255));
        }
    }
}
