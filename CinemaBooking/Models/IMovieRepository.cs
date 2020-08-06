using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Models
{
    public interface IMovieRepository
    {
        //Movie
        public IEnumerable<Movie> GetAllMovies();
        public IEnumerable<Movie> MovieFilterByCateName(string cate);
        public void AddNewMovie(Movie e);
        public void DeleteMovie(int ID);
        public void UpdateMovie(Movie movie);
        public Movie GetMovieById(int id);
        public Movie GetMovieByName(string name);
        public IEnumerable<Time> GetScheduleOfAMovie(int movieId);

        //Category
        public IEnumerable<Category> GetAllCategories();
        public string GetIDCategory(string cateName);
        public string GetNameCategory(string ID);


        //Schedule
        public Time GetSchedule(int ID);
        public void AddNewSchedule(Time model);
        public string GetMaxIDSchedule();
        public List<Time> GetTimeInADate(DateTime now);

        //Booking
        public void AddNewBooking(Booking model);
        public string GetMaxIDBooking();
        public bool IsFullOfSeats(string TimeID);
        //Kiểm tra xem số chỗ ngồi trống có còn đủ cho số lượng vé user đặt hay không? 
        public bool IsAvailableOfSeats(string TimeID, int amount);

        public List<Booking> ListBookingHistory(string userID);
    }
}
