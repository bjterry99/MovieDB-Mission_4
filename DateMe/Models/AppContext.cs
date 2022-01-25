using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieId = 1,
                    Category = "Action",
                    Title = "The Dark Knight",
                    Year = 2008,
                    Director = "Christopher Nolan",
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
                    Director = "Christopher Nolan",
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
                    Director = "Makoto Shinkai",
                    Rating = "PG-13",
                    Edited = false,
                    Lent = "",
                    Notes = "Your Name."
                }
            );
        }
    }
}
