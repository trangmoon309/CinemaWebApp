using CinemaBooking.Ultilities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.ViewModels.Account
{
    public class RegisterViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [PhoneNumberValidate(ErrorMessage = "Kiểm tra lại số điện thoại")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(30,ErrorMessage ="UserName không quá 30 kí tự!")]
        [Remote(action: "IsUserNameUsed", controller: "Account")]
        public string UserName { get; set; }


        [Required]
        [EmailAddress]
        [Remote(action:"IsEmailUsed",controller:"Account")]
        [EmailValidateAttribute(allowedDomain:"gmail.com",ErrorMessage ="Email không đúng format: abc@gmail.com")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Compare("Password",ErrorMessage ="Mật khẩu không khớp.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Xác nhận chấp thuận điều lệ.")]
        public bool IsConfirm { get; set; }
    }
}
