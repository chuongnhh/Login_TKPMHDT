namespace DAL.Migrations
{
    using DOL;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DAL.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //


            if (!context.Groups.Any(x => x.GroupName == "Trưởng phòng"))
            {
                context.Groups.AddOrUpdate(
                new Group
                {
                    GroupName = "Trưởng phòng"
                });
            }
            if (!context.Groups.Any(x => x.GroupName == "Nhân viên"))
            {
                context.Groups.AddOrUpdate(
                new Group
                {
                    GroupName = "Nhân viên"
                });
            }

            if (!context.Users.Any(x => x.UserName == "chuongnh"))
            {
                var g = context.Groups.Where(x => x.GroupName == "Trưởng phòng").FirstOrDefault();
                context.Users.AddOrUpdate(
                new User
                {
                    UserName = "chuongnh",
                    Password = "14110013",
                    FullName = "Nguyễn Hoàng Chương",
                    GroupId = g.Id
                });
            }
            if (!context.Users.Any(x => x.UserName == "phongtt"))
            {
                var g = context.Groups.Where(x => x.GroupName == "Nhân viên").FirstOrDefault();
                context.Users.AddOrUpdate(
                new User
                {
                    UserName = "phongtt",
                    Password = "14110143",
                    FullName = "Trần Thanh Phong",
                    GroupId = g.Id
                });
            }

            if (!context.Roles.Any(x => x.RoleName == "Quản trị"))
            {
                context.Roles.AddOrUpdate(new Role
                {
                    RoleName = "Quản trị"
                });
            }

            if (!context.Roles.Any(x => x.RoleName == "Viết báo cáo"))
            {
                var g = context.Groups.Where(x => x.GroupName == "Trưởng phòng").FirstOrDefault();
                context.Roles.AddOrUpdate(new Role
                {
                    RoleName = "Viết báo cáo",
                });
            }
            if (!context.Roles.Any(x => x.RoleName == "Viết thống kê"))
            {
                var g = context.Groups.Where(x => x.GroupName == "Trưởng phòng").FirstOrDefault();
                context.Roles.AddOrUpdate(new Role
                {
                    RoleName = "Viết thống kê",
                });
            }

            if (!context.Roles.Any(x => x.RoleName == "Xem báo cáo"))
            {
                var g = context.Groups.Where(x => x.GroupName == "Nhân viên").FirstOrDefault();
                context.Roles.AddOrUpdate(new Role
                {
                    RoleName = "Xem báo cáo",
                });
            }
            if (!context.Roles.Any(x => x.RoleName == "Xem thống kê"))
            {
                var g = context.Groups.Where(x => x.GroupName == "Nhân viên").FirstOrDefault();
                context.Roles.AddOrUpdate(new Role
                {
                    RoleName = "Xem thống kê",
                });
            }

            var group1 = context.Groups.Where(x => x.GroupName == "Trưởng phòng").FirstOrDefault();
            if (group1 != null && !group1.Roles.Any(x => x.RoleName == "Viết báo cáo"))
            {
                var role = context.Roles.Where(x => x.RoleName == "Viết báo cáo").FirstOrDefault();
                group1.Roles.Add(role);
            }
            var group2 = context.Groups.Where(x => x.GroupName == "Trưởng phòng").FirstOrDefault();
            if (group2 != null && !group2.Roles.Any(x => x.RoleName == "Viết thống kê"))
            {
                var role = context.Roles.Where(x => x.RoleName == "Viết thống kê").FirstOrDefault();
                group2.Roles.Add(role);
            }

            var group3 = context.Groups.Where(x => x.GroupName == "Nhân viên").FirstOrDefault();
            if (group3 != null && !group3.Roles.Any(x => x.RoleName == "Xem thống kê"))
            {
                var role = context.Roles.Where(x => x.RoleName == "Xem thống kê").FirstOrDefault();
                group3.Roles.Add(role);
            }
            var group4 = context.Groups.Where(x => x.GroupName == "Nhân viên").FirstOrDefault();
            if (group4 != null && !group4.Roles.Any(x => x.RoleName == "Xem báo cáo"))
            {
                var role = context.Roles.Where(x => x.RoleName == "Xem báo cáo").FirstOrDefault();
                group4.Roles.Add(role);
            }

            var user = context.Users.Where(x => x.UserName == "chuongnh").FirstOrDefault();
            if (user != null && !user.Roles.Any(x => x.RoleName == "Quản trị"))
            {
                var role = context.Roles.Where(x => x.RoleName == "Quản trị").FirstOrDefault();
                user.Roles.Add(role);
            }
        }
    }
}
