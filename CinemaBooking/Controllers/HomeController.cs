using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;
using CinemaBooking.Models;
using CinemaBooking.ViewModels.Film;
using CinemaBooking.ViewModels.Home;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace CinemaBooking.Controllers
{
    public class HomeController : Controller
    {
        private IMovieRepository movieRepository;
        private IHostingEnvironment hostingEnvironment;

        public HomeController(IMovieRepository movieRepository, IHostingEnvironment hostingEnvironment)
        {
            this.movieRepository = movieRepository;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult Main()
        {
            IEnumerable<Movie> models = movieRepository.GetAllMovies();

            List<MovieViewModel> moviesView = new List<MovieViewModel>();

            foreach (var item in models.ToList())
            {
                MovieViewModel viewItem = new MovieViewModel()
                {
                    Id = item.Id,
                    Title = item.Title,
                    Photo = item.PhotoPath,
                    Hour = item.Hour,
                    Director = item.Director,
                    Star = item.Star,
                    Type = movieRepository.GetNameCategory(item.CateId),
                    Description = item.Description,
                    fromDate = Convert.ToDateTime(item.StartDate),
                    toDate = Convert.ToDateTime(item.EndDate),
                };

                moviesView.Add(viewItem);
            }

            IEnumerable<Category> cates = movieRepository.GetAllCategories();
            var cateList = cates.ToList();
            ViewBag.Categories = cateList;

            return View(moviesView);
        }


        [HttpGet]
        [Route("api/home/GetMovieByCate/{categoryName}")]
        public IEnumerable<Movie> GetMovieByCate(string categoryName)
        {
            var models = movieRepository.MovieFilterByCateName(categoryName);
            return models;
        }

        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                var messeage = new MimeMessage();
                messeage.From.Add(new MailboxAddress(model.Username, model.FromEmail));
                messeage.To.Add(new MailboxAddress("Trang Huỳnh", "huynhphuongtrang309@gmail.com"));

                messeage.Subject = "Lời nhắn đến từ người dùng Cinema Booking Ticket";
                messeage.Body = new TextPart("plain")
                {
                    Text = model.Messeage
                };

                using (var client = new MailKit.Net.Smtp.SmtpClient())

                {
                    try
                    {

                        client.Connect("smtp.gmail.com", 587, false);

                        client.Authenticate(model.FromEmail, model.Password); // If using GMail this requires turning on LessSecureApps : https://myaccount.google.com/lesssecureapps
                        client.Send(messeage);
                        client.Disconnect(true);
                    } catch(Exception ee)
                    {
                        ModelState.AddModelError("", "Kiểm tra lại email và password!");
                        return View();
                    }
                }

                ModelState.AddModelError("", "Gửi thành công!");
            }
            return View(model);
        }
    }
}
