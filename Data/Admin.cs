using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalERPNew.Data
{
    public class Admin
    {
        public int Id { get; set; }
        public AppUser User { get; set; }
        public int UserId { get; set; }
    }
}