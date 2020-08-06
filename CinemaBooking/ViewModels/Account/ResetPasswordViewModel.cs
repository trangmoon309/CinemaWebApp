using CinemaBooking.Ultilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.ViewModels.Account
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [EmailValidateAttribute(allowedDomain: "gmail.com", ErrorMessage = "Email không đúng format: abc@gmail.com")]
        [Remote(action: "IsEmailExist", controller: "Account")]
        public string Email { get; set; }
    }
}
