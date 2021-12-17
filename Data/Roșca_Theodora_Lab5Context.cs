using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Roșca_Theodora_Lab5.Models;

namespace Roșca_Theodora_Lab5.Data
{
    public class Roșca_Theodora_Lab5Context : DbContext
    {
        public Roșca_Theodora_Lab5Context (DbContextOptions<Roșca_Theodora_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Roșca_Theodora_Lab5.Models.Book> Book { get; set; }

        public DbSet<Roșca_Theodora_Lab5.Models.Publisher> Publisher { get; set; }

        public DbSet<Roșca_Theodora_Lab5.Models.Category> Category { get; set; }
    }
}
