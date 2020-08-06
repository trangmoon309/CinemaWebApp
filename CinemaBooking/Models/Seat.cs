using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Models
{
    public class Seat
    {
        public string Id { get; set; }
        public bool IsAvailable { get; set; }
        public string IdTime { get; set; }
        public int IdMovie { get; set; }

    }
}
