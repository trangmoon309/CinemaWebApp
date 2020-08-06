using CinemaBooking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.ViewModels.Film
{
    public class BookingViewModel
    {
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Số điện thoại")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Tên đầy đủ")]
        public string FullName { get; set; }
        public string UserID { get; set; }
        public int Amount { get; set; }
        public float TotalBill { get; set; }
        public Movie Movie { get; set; }
        public string TimeID { get; set; }
    }
}
