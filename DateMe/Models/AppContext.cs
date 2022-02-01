using Microsoft.EntityFrameworkCore;
using DateMe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Models
{
    public class AppContext : DbContext
    {
        public AppContext (DbContextOptions<AppContext> options) : base (options)
        {
            //temp blank
        }

        public DbSet<ApplicationResponse> responses { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Director>().HasData(
                new Director { DirectorID=1, DirectorName="Christopher Nolan"},
                new Director { DirectorID = 2, DirectorName = "makato shinkai" }
            );

            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Action/Adventure" },
                new Category { CategoryID = 2, CategoryName = "Comedy" },
                new Category { CategoryID = 3, CategoryName = "Drama" },
                new Category { CategoryID = 4, CategoryName = "Family" },
                new Category { CategoryID = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryID = 6, CategoryName = "Misc." },
                new Category { CategoryID = 7, CategoryName = "Television" },
                new Category { CategoryID = 8, CategoryName = "VHS" }
            );

            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    CategoryID = 1,
                    Title = "The Dark Knight",
                    Year = 2008,
                    DirectorID = 1,
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = "im batman"
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    CategoryID = 1,
                    Title = "Interstellar",
                    Year = 2014,
                    DirectorID = 1,
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = "im not batman"
                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    CategoryID = 3,
                    Title = "kimi no na ha",
                    Year = 2016,
                    DirectorID = 2,
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = "Your Name."
                }
            );
        }
    }
}
