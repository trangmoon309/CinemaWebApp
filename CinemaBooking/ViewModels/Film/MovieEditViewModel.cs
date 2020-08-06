using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.ViewModels.Film
{
    public class MovieEditViewModel : MovieCreateViewModel
    {
        public int movieID { get; set; }
        public string PhotoPath { get; set; }
       
    }
}
