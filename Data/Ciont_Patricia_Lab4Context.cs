using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ciont_Patricia_Lab4.Models;

namespace Ciont_Patricia_Lab4.Data
{
    public class Ciont_Patricia_Lab4Context : DbContext
    {
        public Ciont_Patricia_Lab4Context (DbContextOptions<Ciont_Patricia_Lab4Context> options)
            : base(options)
        {
        }

        public DbSet<Ciont_Patricia_Lab4.Models.Book> Book { get; set; } = default!;
        public DbSet<Ciont_Patricia_Lab4.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Ciont_Patricia_Lab4.Models.Author> Author { get; set; } = default!;
        public DbSet<Ciont_Patricia_Lab4.Models.Category> Category { get; set; } = default!;
    }
}
