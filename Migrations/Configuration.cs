namespace HospitalERPNew.Migrations
{
    using HospitalERPNew.Data;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HospitalERPNew.Data.HospitalDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(HospitalERPNew.Data.HospitalDbContext context)
        {
            context.AppUsers.AddOrUpdate(new AppUser
            {
                Id = 1,
                Email = "admin@gmail.com",
                Name = "Telman",
                Surname = "Yusifov",
                Username = "Telmxn",
                Password = "12345678",
                UserRole = UserType.Admin
            },
            new AppUser
            {
                Id = 2,
                Email = "Reception@gmail.com",
                Name = "Elekber",
                Surname = "Elekberov",
                Username = "ElekberReception",
                Password = "12345678",
                UserRole = UserType.Reception
            },
            new AppUser
            {
                Id = 3,
                Email = "Doctor@gmail.com",
                Name = "Kamran",
                Surname = "Qasimov",
                Username = "KamranDoctor",
                Password = "12345678",
                UserRole = UserType.Doctor
            });

            context.Admins.AddOrUpdate(new Admin
            {
                Id = 1,
                UserId = 1
            });
            context.Receptions.AddOrUpdate(new Reception
            {
                Id = 1,
                UserId = 2
            });
            context.Doctors.AddOrUpdate(new Doctor
            {
                Id = 1,
                UserId = 3
            });

            context.UserRoles.AddOrUpdate(new UserRole
            {
                Id = 1,
                UserId = 1,
                Role = "Admin"
            },
            new UserRole
            {
                Id = 2,
                UserId = 2,
                Role = "Reception"
            },
            new UserRole
            {
                Id = 2,
                UserId = 3,
                Role = "Doctor"
            });

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
