using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission06_km2264.Models
{
    public class MovieContext : DbContext
    {
        //Constructor
        public MovieContext (DbContextOptions<MovieContext> options) : base(options)
        {

        }
        public DbSet<EnterMovieResponse> responses { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<EnterMovieResponse>().HasData(
                //Add three movies to database
                new EnterMovieResponse
                {
                    Id = 1,
                    Category = "Drama",
                    Title = "Flying Colors",
                    Year = 2015,
                    Director = "Nobuhiro Doi",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                new EnterMovieResponse
                {
                    Id = 2,
                    Category = "Romance",
                    Title = "We Made a Beautiful Bouquet",
                    Year = 2021,
                    Director = "Nobuhiro Doi",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                },
                new EnterMovieResponse
                {
                    Id = 3,
                    Category = "Action",
                    Title = "Dragonball Super: Super Hero",
                    Year = 2022,
                    Director = "Testuro Kodama",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = ""
                }
            );
        }
    }
}
