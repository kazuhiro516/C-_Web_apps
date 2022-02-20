#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RozorPagesMovie.Models;

namespace RozorPagesMovie.Data
{
    public class RozorPagesMovieContext : DbContext
    {
        public RozorPagesMovieContext (DbContextOptions<RozorPagesMovieContext> options)
            : base(options)
        {
        }

        public DbSet<RozorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
