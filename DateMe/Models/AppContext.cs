using Microsoft.EntityFrameworkCore;
using Movies.Models;
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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Director>().HasData(
                new Director { DirectorID=1, DirectorName="Christopher Nolan"},
                new Director { DirectorID = 2, DirectorName = "makato shinkai" }
            );


            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    Category = "Action",
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
                    Category = "Space",
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
                    Category = "Drama",
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
