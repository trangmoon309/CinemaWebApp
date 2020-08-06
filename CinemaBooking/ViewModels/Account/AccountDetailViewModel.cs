using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.ViewModels.Account
{
    public class AccountDetailViewModel
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [Compare(otherProperty:"Password",ErrorMessage ="Mật khẩu không khớp!")]
        public string ConfirmPassword { get; set; }
    }
}
