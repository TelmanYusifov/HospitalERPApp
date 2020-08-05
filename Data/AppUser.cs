using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalERPNew.Data
{
    public enum UserType
    {
        Admin,
        Doctor,
        Reception
    }
    public class AppUser
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 3)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 60, MinimumLength = 3)]
        public string Surname { get; set; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 3)]
        public string Username { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 8)]
        public string Password { get; set; }
        public UserType UserRole { get; set; }
    }
}