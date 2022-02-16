namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class formating : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RideModels", "SpecialNeed", c => c.String(maxLength: 500));
            AlterColumn("dbo.RideModels", "LenghtOfAppointment", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RideModels", "LenghtOfAppointment", c => c.String());
            AlterColumn("dbo.RideModels", "SpecialNeed", c => c.String());
        }
    }
}
