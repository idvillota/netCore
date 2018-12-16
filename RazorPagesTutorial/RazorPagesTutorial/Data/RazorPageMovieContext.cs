using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesTutorial.Models
{
    public class RazorPageMovieContext : DbContext
    {
        public RazorPageMovieContext (DbContextOptions<RazorPageMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesTutorial.Models.Movie> Movie { get; set; }
    }
}
