using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalERPNew.Data
{
    public class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Role { get; set; }
    }
}