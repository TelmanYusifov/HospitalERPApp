using HospitalERPNew.Data;
using HospitalERPNew.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HospitalERPNew.Infrastructure
{
    public static class DbSetExtensions
    {
        public static AppUser UserExists(this DbSet<AppUser> appUsers, LoginModel loginModel)
        {
            return appUsers.Where(x => x.Email == loginModel.Email && x.Password.Equals(loginModel.Password)).SingleOrDefault();
        }
    }
}