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
        public DbSet<EnterMovieResponse> Responses { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category {CategoryId = 1, CategoryName = "Action"},
                new Category {CategoryId = 2, CategoryName = "Adventure"},
                new Category {CategoryId = 3, CategoryName = "Romance"},
                new Category {CategoryId = 4, CategoryName = "Horror"},
                new Category {CategoryId = 5, CategoryName = "Fantasy"},
                new Category {CategoryId = 6, CategoryName = "Sci-Fi"},
                new Category {CategoryId = 7, CategoryName = "Mystery"},
                new Category {CategoryId = 8, CategoryName = "Comedy"},
                new Category {CategoryId = 9, CategoryName = "Musical"},
                new Category {CategoryId = 10, CategoryName = "Western"},
                new Category {CategoryId = 11, CategoryName = "Drama"},
                new Category {CategoryId = 12, CategoryName = "Documentary"}
                );

            mb.Entity<EnterMovieResponse>().HasData(
                //Add three movies to database
                new EnterMovieResponse
                {
                    Id = 1,
                    CategoryId = 12,
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
                    CategoryId = 3,
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
                    CategoryId = 1,
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
