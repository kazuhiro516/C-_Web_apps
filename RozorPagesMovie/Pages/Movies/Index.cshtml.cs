#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RozorPagesMovie.Data;
using RozorPagesMovie.Models;

namespace RozorPagesMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RozorPagesMovie.Data.RozorPagesMovieContext _context;

        public IndexModel(RozorPagesMovie.Data.RozorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
