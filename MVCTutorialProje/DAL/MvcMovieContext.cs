using Microsoft.EntityFrameworkCore;
using MVCTutorialProje.Models;
using System.Collections.Generic;

namespace MVCTutorialProje.DAL
{
    public class MvcMovieContext:DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
         : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
