using CinemaBooking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.ViewModels.Film
{
    public class ScheduleCreateViewModel
    {
        public ScheduleCreateViewModel()
        {
            Movies = new List<Movie>();
        }
        public List<Movie> Movies { get; set; }

        [Required]
        public string movieName { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string FromTime { get; set; }
        public int movieID { get; set; }

    }
}
