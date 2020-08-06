using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaBooking.Models
{
    public static class ModelBuilderExtensionMethod
    {
        
        public static void Seed(this ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    Id = "01",
                    Name = "Action"
                },
                new Category()
                {
                    Id = "02",
                    Name = "Comedy"
                },
                new Category()
                {
                    Id = "03",
                    Name = "Romantic"
                },
                new Category()
                {
                    Id = "04",
                    Name = "Adventure"
                }
           );



        }
    }
}
