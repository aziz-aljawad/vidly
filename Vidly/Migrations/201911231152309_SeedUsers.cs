namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8ef4e545-db32-4176-89ff-5840cdb1599a', N'guest@vidly.com', 0, N'AN9dsQKCTUkDJYfOicPBpkwElE1cdHRat6u3X4lUCLqbQeJ4T4I7vLJunX/RodAaIw==', N'7c9be02d-57d0-41c3-8faa-cad8472962d1', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                   INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c154a242-f97d-4bf4-b5bb-6e9e90deb636', N'admin@vidly.com', 0, N'AEXxI2eH1kpnknOxpmvFbA46P7EGAw4MzMXqhsGpshzcRwxfDQ0yIOrjGpvWkm6NyQ==', N'2d37fd81-6312-42b2-a418-a8e460de702b', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                   INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'afc2e491-ec7d-4dd5-80fe-90f9f4d7c0d6', N'CanManageMovies')
                   INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c154a242-f97d-4bf4-b5bb-6e9e90deb636', N'afc2e491-ec7d-4dd5-80fe-90f9f4d7c0d6')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
