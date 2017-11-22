namespace InternshipLink.Web.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<InternshipLink.Web.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Data\Migrations";
        }

        protected override void Seed(InternshipLink.Web.Data.DataContext context)
        { 
            context.Roles.Add(new IdentityRole { Id = "ADMINISTRATOR", Name = "Administrator" });
            context.SaveChanges();
            context.Roles.Add(new IdentityRole { Id = "STUDENT", Name = "Student" });
            context.SaveChanges();

            var adminRole = context.Roles.SingleOrDefault(r => r.Name == "Administrator");
            var studentRole = context.Roles.SingleOrDefault(r => r.Name == "Student");

            var hasher = new PasswordHasher();

            var admin = new ApplicationUser
            {
                UserName = "admin@admin.com",
                PasswordHash = hasher.HashPassword("admin"),
                Email = "admin@admin.com",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var student = new ApplicationUser
            {
                UserName = "student@student.com",
                PasswordHash = hasher.HashPassword("student"),
                Email = "student@student.com",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            admin.Roles.Add(new IdentityUserRole { RoleId = adminRole.Id, UserId = admin.Id });
            student.Roles.Add(new IdentityUserRole { RoleId = adminRole.Id, UserId = student.Id });

            context.Users.Add(admin);
            context.SaveChanges();
            context.Users.Add(student);
            context.SaveChanges();

            base.Seed(context);


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
        }
    }
}
