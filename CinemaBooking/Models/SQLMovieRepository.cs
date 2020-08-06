using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Models
{
    public class SQLMovieRepository : IMovieRepository
    {
        private readonly AppDbContext context;

        public SQLMovieRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return context.Movies;
        }

        public void AddNewMovie(Movie e)
        {
            context.Movies.Add(e);
            context.SaveChanges();
        }

        public void DeleteMovie(int ID)
        {
            var movie = context.Movies.FirstOrDefault(c => c.Id == ID);
            context.Movies.Remove(movie);
            context.SaveChanges();
        }

        public void UpdateMovie(Movie movie)
        {
            var reusult = context.Movies.FirstOrDefault(c => c.Id == movie.Id);
            reusult.Title = movie.Title;
            reusult.Language = movie.Language;
            reusult.PhotoPath = movie.PhotoPath;
            reusult.Hour = movie.Hour;
            reusult.StartDate = movie.StartDate;
            reusult.EndDate = movie.EndDate;
            reusult.Director = movie.Director;
            reusult.Description = movie.Description;
            reusult.Star = movie.Star;
            reusult.CateId = movie.CateId;

            context.SaveChanges();

        }

        public Movie GetMovieById(int id)
        {
            var result = context.Movies.FirstOrDefault(c => c.Id == id);
            return result;
        }

        public IEnumerable<Movie> MovieFilterByCateName(string cateName)
        {
            var cateId = context.Categories.FirstOrDefault(c => c.Name == cateName).Id;
            var result = context.Movies.Where(c => c.CateId == cateId);
            return result;
        }

        public Movie GetMovieByName(string name)
        {
            var result = context.Movies.FirstOrDefault(c => c.Title == name);
            return result;
        }

        public IEnumerable<Time> GetScheduleOfAMovie(int movieId)
        {
            var result = from movie in context.Movies
                         join time in context.Times on movie.Id equals time.IDMovie
                         select time;

            return result;
        }



        //Category
        public IEnumerable<Category> GetAllCategories()
        {
            return context.Categories;
        }


        public string GetIDCategory(string cateName)
        {
            var result = context.Categories.FirstOrDefault(c => c.Name == cateName);
            return result.Id;
        }

        public string GetNameCategory(string ID)
        {
            var result = context.Categories.FirstOrDefault(c => c.Id == ID);
            return result.Name;
        }

        //Schedule
        public void AddNewSchedule(Time model)
        {
            context.Times.Add(model);
            context.SaveChanges();
        }
        public string GetMaxIDSchedule()
        {
            var result = context.Times.Max(c => Convert.ToInt32(c.Id));
            result++;
            return result.ToString();
        }
        public List<Time> GetTimeInADate(DateTime now)
        {
            string dateNow = now.ToShortDateString();
            var result = from time in context.Times
                         where (String.Equals(dateNow, time.Date) == true)
                         select time;
            return result.ToList();

        }


        //Booking

        public Time GetSchedule(int ID)
        {
            var result = from item in context.Times
                         where Convert.ToInt32(item.Id) == ID
                         select item;
            return result.First();
        }
        public string GetMaxIDBooking()
        {
            var result = context.Bookings.Max(c => Convert.ToInt32(c.Id));
            result++;
            return result.ToString();
        }
        public void AddNewBooking(Booking model)
        {
            context.Bookings.Add(model);
            context.SaveChanges();
        }

        public bool IsFullOfSeats(string TimeID)
        {
            var result = from item in context.Bookings
                         where Convert.ToInt32(item.Id) == Convert.ToInt32(TimeID)
                         select item.Amount;
            int total = 0;
            foreach(var item in result)
            {
                total += item;
            }

            if(total == 50) return true;
            return false;
        }

        public bool IsAvailableOfSeats(string TimeID, int amount)
        {
            var result = from item in context.Bookings
                         where Convert.ToInt32(item.Id) == Convert.ToInt32(TimeID)
                         select item.Amount;
            int total = 0;
            foreach (var item in result)
            {
                total += item;
            }

            if (total + amount <= 50) return true;
            return false;
        }

        public List<Booking> ListBookingHistory(string userID)
        {
            var result = from item in context.Bookings
                         where String.Equals(item.UserID, userID) == true
                         select item;
            return result.ToList();
        }

    }
}

