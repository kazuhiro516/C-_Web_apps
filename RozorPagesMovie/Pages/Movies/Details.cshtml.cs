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
    public class DetailsModel : PageModel
    {
        private readonly RozorPagesMovie.Data.RozorPagesMovieContext _context;

        public DetailsModel(RozorPagesMovie.Data.RozorPagesMovieContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
