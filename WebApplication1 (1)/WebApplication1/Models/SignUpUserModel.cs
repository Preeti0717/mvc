﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage ="Please enter your email")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage ="Please enter a valid email")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Please enter a strong password")]
        [Compare("ConfirmPassword",ErrorMessage ="Password does not match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required(ErrorMessage = "Please confirm your password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
