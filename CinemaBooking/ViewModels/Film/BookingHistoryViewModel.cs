using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.ViewModels.Film
{
    public class BookingHistoryViewModel
    {
        public int IDTicket { get; set; }
        public string BookingDate { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Title { get; set; }
        public string FromTime { get; set; }
        public int Amount { get; set; }
        public float Total { get; set; }
    }
}
