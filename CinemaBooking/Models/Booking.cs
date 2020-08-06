using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Models
{
    public class Booking
    {
        public string Id { get; set; }
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string UserID { get; set; }
        public int MovieID { get; set; }
        public string TimeID { get; set; }
        public int Amount { get; set; }
        public float TotalBill { get; set; }
    }
}
