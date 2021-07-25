using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstRazor.Data;
using FirstRazor.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FirstRazor.Data.FirstRazorContext _context;

        public IndexModel(FirstRazor.Data.FirstRazorContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Genres { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MovieGenre { get; set; }

        public async Task OnGetAsync()
        {
            var movies = from m in _context.Movie
                         select m;
        }
    }
}
