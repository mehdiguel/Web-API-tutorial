namespace Web_API_tutorial.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'78d0e4b4-8b34-4a95-9ac2-c4c59935e11d', N'mehdi@gmail.com', 0, N'AHFuVQrxXGuD9uTi53utsESOQ7AXEk9PCNBw/FnLsuN0Y9Z1a/syn41CiuP3h1Hmig==', N'6409e947-bfda-4264-b793-a9d005b9c5b9', NULL, 0, 0, NULL, 1, 0, N'mehdi@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9a7956bb-9d12-468b-bd8c-130b4d5a3f5b', N'admin@gmail.com', 0, N'ANEaBLGzoMwZNXdAsYzTjWA+TCbMupKUaMVl8nRm0mtdVC35mq5WXpKQ96zIZP8QtQ==', N'6627bb79-0bdb-4ea5-844b-72571e97e976', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'c5262c96-1e3b-49e5-a3f0-a32a6d3014f8', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9a7956bb-9d12-468b-bd8c-130b4d5a3f5b', N'c5262c96-1e3b-49e5-a3f0-a32a6d3014f8')
");
        }
        
        public override void Down()
        {
        }
    }
}
