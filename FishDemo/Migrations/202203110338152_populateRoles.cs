namespace FishDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateRoles : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3', N'Driver')
                    
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2', N'Manager')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9065aef7-b377-4f8e-a575-88179ab39c9a', N'manager@fish.com', 0, N'ANoZBeAP83fM0iASQseYpj8X+ePavs18rfs2lWJf43ckEjenIvmTZtdkyqACedGWkA==', N'e5b1aa50-c95b-41a5-b623-934e5af95433', NULL, 0, 0, NULL, 1, 0, N'manager@fish.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'96b2d779-9465-4fd4-b4c6-a6a7bc99d798', N'driver@fish.com', 0, N'APahVD1Q/G5TDRkHHrlzrzxapM7UFO8uzN/38boaxDJL714M50bkbsjEdOpOG1u25w==', N'2a924db8-674b-41a7-9225-f7fef72b5d91', NULL, 0, 0, NULL, 1, 0, N'driver@fish.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a45b4fd4-7615-445b-837a-5d9d7f5bfc7c', N'jhc@fish.com', 0, N'ANyiKArJXNIOXtu0JI90AgrOMOVPkvqiEYJFir7y+UJzcWa3MxPUC0gJfDQOrSHdVQ==', N'10cccc5d-e1a9-41f7-baf3-a2178bbde148', NULL, 0, 0, NULL, 1, 0, N'jhc@fish.com')

                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9065aef7-b377-4f8e-a575-88179ab39c9a', N'2')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a45b4fd4-7615-445b-837a-5d9d7f5bfc7c', N'2')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'96b2d779-9465-4fd4-b4c6-a6a7bc99d798', N'3')"





            );


        }
        
        public override void Down()
        {
        }
    }
}
