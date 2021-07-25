using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FirstRazor.Data;
using FirstRazor.Models;

namespace FirstRazor.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly FirstRazor.Data.FirstRazorContext _context;

        public IndexModel(FirstRazor.Data.FirstRazorContext context)
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
