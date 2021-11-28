using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tomoroga_Mioara_Lab8.Models;

namespace Tomoroga_Mioara_Lab8.Data
{
    public class Tomoroga_Mioara_Lab8Context : DbContext
    {
        public Tomoroga_Mioara_Lab8Context (DbContextOptions<Tomoroga_Mioara_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Tomoroga_Mioara_Lab8.Models.Book> Book { get; set; }

        public DbSet<Tomoroga_Mioara_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Tomoroga_Mioara_Lab8.Models.Category> Category { get; set; }
    }
}
