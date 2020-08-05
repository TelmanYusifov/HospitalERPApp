using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HospitalERPNew.Data
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext() : base("HospitalDbConnection") { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
    }
}