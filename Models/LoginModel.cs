﻿using HospitalERPNew.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HospitalERPNew.Models
{
    public class LoginModel
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 30, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Please fill Email Input.")]
        public string Email { get; set; }
    }
}