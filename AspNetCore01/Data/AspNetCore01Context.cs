using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AspNetCore01.Models
{
    public class AspNetCore01Context : DbContext
    {
        public AspNetCore01Context (DbContextOptions<AspNetCore01Context> options)
            : base(options)
        {
        }

        public DbSet<AspNetCore01.Models.Movie> Movie { get; set; }
    }
}
