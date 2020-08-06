using CinemaBooking.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.ViewModels.Film
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public int Hour { get; set; }
        public string Director { get; set; }
        public string Star { get; set; }
        public string Type { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public string Description { get; set; }
        public List<Time> Schedule { get; set; }
    }
}
