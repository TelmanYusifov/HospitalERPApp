using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalERPNew.Data
{
    public class Doctor
    {
        public int Id { get; set; }
        public AppUser User { get; set; }
        public int UserId { get; set; }
    }
}