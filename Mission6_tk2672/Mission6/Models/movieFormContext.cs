using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Models
{
    public class movieFormContext : DbContext
    {
        //Constructor
        public movieFormContext (DbContextOptions<movieFormContext> options): base(options)
        {
            //leave blank
        }

        public DbSet<FormResponse> responses { get; set; }

        //loading
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(

                new FormResponse
                {
                    //category
                    //director
                    //edited
                    //lentto
                    //notes
                    //rating
                    //title
                    //year
                    AppID = 1,
                    Category = "Comedy",
                    Director = "Idk but someone good probably",
                    Edited = true,
                    LentTo = "Faline",
                    Notes = "Quite good indeed",
                    Rating = "PG",
                    Title = "Fantastic Mr. Fox",
                    Year = 2009
                },
                new FormResponse
                {
                    AppID = 2,
                    Category = "Adventure",
                    Director = "Christopher Nolan",
                    Edited = true,
                    LentTo = "Your mother",
                    Notes = "WOWOWOWOWOW",
                    Rating = "PG-13",
                    Title = "Interstellar",
                    Year = 2014
                },
                new FormResponse
                {
                    AppID = 3,
                    Category = "Fantasy",
                    Director = "Hayao Miyazaki",
                    Edited = true,
                    LentTo = "My ex #rip",
                    Notes = "pretty dang good",
                    Rating = "PG",
                    Title = "Spirited Away",
                    Year = 2001
                }
            );
        }
    }
}
