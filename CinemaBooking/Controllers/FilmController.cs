using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CinemaBooking.Models;
using CinemaBooking.ViewModels.Film;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CinemaBooking.Controllers
{
    public class FilmController : Controller
    {
        private UserManager<ApplicationUser> userManager { get; set; }

        private IMovieRepository _movieRepository;
        private IHostingEnvironment hostingEnvironment;
        public FilmController(UserManager<ApplicationUser> userManager, IMovieRepository movieRepository, IHostingEnvironment hostingEnvironment)
        {
            _movieRepository = movieRepository;
            this.hostingEnvironment = hostingEnvironment;
            this.userManager = userManager;

        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateFilm()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult CreateFilm(MovieCreateViewModel model)
        {
            if (ModelState.IsValid)
            {

                string uniqueName = null;
                if (model.Photo != null)
                {
                    string root = Path.Combine(hostingEnvironment.WebRootPath + "/imgs/films");
                    uniqueName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;

                    string filePath = Path.Combine(root, uniqueName);

                    model.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Bạn chưa chọn hình ảnh.");
                    return View(model);
                }

                if(DateTime.Compare(model.StartDate,model.EndDate) > 0)
                {
                    ModelState.AddModelError(string.Empty, "Ngày kết thúc phải muộn hơn ngày bắt đầu chiếu!");
                    return View(model);
                }

                if(model.Hour > 4)
                {
                    ModelState.AddModelError(string.Empty, "Phim chiếu rạp không được quá 4 tiếng!");
                    return View(model);
                }

                Movie movie = new Movie()
                {
                    Title = model.Title,
                    Language = model.Language,
                    CateId = _movieRepository.GetIDCategory(model.Type),
                    Hour = model.Hour,
                    Director = model.Director,
                    Star = model.Star,
                    Description = model.Description,
                    StartDate = model.StartDate.ToString(),
                    EndDate = model.EndDate.ToString(),
                    PhotoPath = uniqueName
                };

                _movieRepository.AddNewMovie(movie);
            }
            return View(model);
        }

        [HttpGet]
        [Authorize]
        public IActionResult BookingTicket(string MovieID, string TimeID)
        {
            string UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var userName = User.FindFirstValue(ClaimTypes.Name);
            Movie movie = _movieRepository.GetMovieById(Convert.ToInt32(MovieID));
            BookingViewModel model = new BookingViewModel()
            {
                Movie = movie,
                TimeID = TimeID,
                UserID = UserID,
                UserName = userName,
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult BookingTicket(BookingViewModel model)
        {
            if (ModelState.IsValid)
            {
                if(_movieRepository.IsFullOfSeats(model.TimeID))
                {
                    ModelState.AddModelError("", "Suất này hiện đã hết chỗ ngồi!");
                    return View(model);
                }
                if (!(_movieRepository.IsAvailableOfSeats(model.TimeID, model.Amount)))
                {
                    ModelState.AddModelError("", "Bạn nên giảm số lượng vé lại vì số lượng vé mà bạn muốn đặt quá giới hạn chỗ ngồi hiện tại!");
                    return View(model);
                }
                Booking book = new Booking()
                {
                    Id = _movieRepository.GetMaxIDBooking(),
                    UserName = model.UserName,
                    PhoneNumber = model.PhoneNumber,
                    FullName = model.FullName,
                    UserID = model.UserID,
                    Amount = model.Amount,
                    TotalBill = model.TotalBill,
                    MovieID = model.Movie.Id,
                    TimeID = model.TimeID
                };

                _movieRepository.AddNewBooking(book);
            }
            return View(model);
        }


        [HttpGet]
        public IActionResult FilmDetail(int filmId)
        {
            Movie movie = _movieRepository.GetMovieById(filmId);
            DateTime getTimeNow = DateTime.Now.Date;

            List<Time> scheduleOfDateNow = _movieRepository.GetTimeInADate(getTimeNow);

            MovieViewModel model = new MovieViewModel()
            {
                Id = movie.Id,
                Title = movie.Title,
                Photo = movie.PhotoPath,
                Hour = movie.Hour,
                Director = movie.Director,
                Star = movie.Star,
                Type = _movieRepository.GetNameCategory(movie.CateId),
                Description = movie.Description,
                toDate = Convert.ToDateTime(movie.EndDate),
                Schedule = scheduleOfDateNow
            };
            return View(model);
        }


        [HttpGet]
        public IActionResult CreateSchedule()
        {
            ScheduleCreateViewModel model = new ScheduleCreateViewModel();
            IEnumerable<Movie> movies = _movieRepository.GetAllMovies();

            foreach (var item in movies.ToList())
            {
                model.Movies.Add(item);
            }
            return View(model);
        }

        [HttpGet]
        [Route("api/home/GetDatesOfMovie/{movieName}")]
        public List<string> GetDatesOfMovie(string movieName)
        {
            List<string> dates = new List<string>();
            Movie movie = _movieRepository.GetMovieByName(movieName);

            List<DateTime> allDates = new List<DateTime>();
            DateTime startDate = Convert.ToDateTime(movie.StartDate);
            DateTime endDate = Convert.ToDateTime(movie.EndDate);
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
                allDates.Add(date);

            foreach (var item in allDates)
            {
                dates.Add(item.ToShortDateString());
            }
            return dates;
        }

        [HttpPost]
        public IActionResult CreateSchedule(ScheduleCreateViewModel model)
        {
            ScheduleCreateViewModel originalModel = new ScheduleCreateViewModel();
            IEnumerable<Movie> movies = _movieRepository.GetAllMovies();

            foreach (var item in movies.ToList())
            {
                originalModel.Movies.Add(item);
            }

            if (ModelState.IsValid)
            {
                Movie movie = _movieRepository.GetMovieByName(model.movieName);

                List<Time> SchedulesofModel = _movieRepository.GetScheduleOfAMovie(movie.Id).ToList();

                foreach(var item in SchedulesofModel)
                {
                    if (String.Equals(item.fromTime, model.FromTime) && Convert.ToDateTime(item.Date).Date == model.Date)
                    {
                        ModelState.AddModelError("", $"Phim {model.movieName} vào ngày {model.Date.ToShortDateString()} đã tồn tại khung giờ này.");
                        return View(originalModel);
                    }
                }
                Time schedule = new Time()
                {
                    Id = _movieRepository.GetMaxIDSchedule(),
                    IDMovie = movie.Id,
                    fromTime = model.FromTime,
                    Date = model.Date.ToShortDateString()
                };

                _movieRepository.AddNewSchedule(schedule);
            }
            return View(originalModel);
        }


        [HttpGet]
        public IActionResult BookingHistory()
        {
            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            List<Booking> bookingHistories = _movieRepository.ListBookingHistory(userID);
            List<BookingHistoryViewModel> model = new List<BookingHistoryViewModel>();
            foreach(var item in bookingHistories)
            {
                string MovieName = _movieRepository.GetMovieById(item.MovieID).Title;
                Time getTime = _movieRepository.GetSchedule(Convert.ToInt32(item.TimeID));

                BookingHistoryViewModel modelItem = new BookingHistoryViewModel()
                {
                    IDTicket = Convert.ToInt32(item.Id),
                    FullName = item.FullName,
                    PhoneNumber = item.PhoneNumber,
                    Amount = item.Amount,
                    Total = item.TotalBill,
                    Title = MovieName,
                    BookingDate = getTime.Date,
                    FromTime = getTime.fromTime
                };

                model.Add(modelItem);
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult ListFilm()
        {
            IEnumerable<Movie> movies = _movieRepository.GetAllMovies();
            List<Movie> model = movies.ToList();
            return View(model);
            //Show list film, chỉ có ảnh và tiêu đề, có nút xem chi tiết, đặt vé, admin có thêm xóa,sửa
        }

        [HttpGet]
        public IActionResult DeleteFilm(int FilmId, string movieName)
        {
            ViewBag.Name = movieName;
            ViewBag.ID = FilmId;
            return View();
        }

        [HttpPost]
        public IActionResult DeleteFilm(int FilmId)
        {
            _movieRepository.DeleteMovie(FilmId);
            return RedirectToAction("ListFilm");
        }

        [HttpGet]
        public IActionResult EditFilm(int FilmId)
        {
            Movie movie = _movieRepository.GetMovieById(FilmId);
            MovieEditViewModel model = new MovieEditViewModel()
            {
                movieID = FilmId,
                Title = movie.Title,
                Language = movie.Language,
                PhotoPath = movie.PhotoPath,
                Hour = movie.Hour,
                StartDate = Convert.ToDateTime(movie.StartDate),
                EndDate = Convert.ToDateTime(movie.EndDate),
                Director = movie.Director,
                Description = movie.Description,
                Star = movie.Star,
                Type = _movieRepository.GetNameCategory(movie.CateId)
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult EditFilm(MovieEditViewModel model)
        {
            Movie movie = _movieRepository.GetMovieById(model.movieID);
            movie.Title = model.Title;
            movie.Language = model.Language;
            movie.PhotoPath = model.PhotoPath;
            movie.Hour = model.Hour;
            movie.StartDate = model.StartDate.ToShortDateString();
            movie.EndDate = model.EndDate.ToShortDateString();
            movie.Director = model.Director;
            movie.Description = model.Description;
            movie.Star = model.Star;
            movie.CateId = _movieRepository.GetIDCategory(model.Type);

            _movieRepository.UpdateMovie(movie);
            ModelState.AddModelError("", "Cập nhật thành công!");
            return RedirectToAction("EditFilm", new { FilmId = movie.Id });
        }
    }
}
