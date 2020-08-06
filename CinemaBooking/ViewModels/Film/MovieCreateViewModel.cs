using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.ViewModels.Film
{
    public class MovieCreateViewModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Language { get; set; }

        public IFormFile Photo { get; set; }

        [Required]
        public int Hour { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Star { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Mô tả không quá 500 từ.")]
        public string Description { get; set; }


    }
}
