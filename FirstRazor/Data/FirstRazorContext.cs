using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FirstRazor.Models;

namespace FirstRazor.Data
{
    public class FirstRazorContext : DbContext
    {
        public FirstRazorContext (DbContextOptions<FirstRazorContext> options)
            : base(options)
        {
        }

        public DbSet<FirstRazor.Models.Movie> Movie { get; set; }
    }
}
