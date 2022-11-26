using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bianca_Teodora_Lab2.Models;

namespace Bianca_Teodora_Lab2.Data
{
    public class Bianca_Teodora_Lab2Context : DbContext
    {
        public Bianca_Teodora_Lab2Context (DbContextOptions<Bianca_Teodora_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Bianca_Teodora_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Bianca_Teodora_Lab2.Models.Publisher> Publisher { get; set; }

        public DbSet<Bianca_Teodora_Lab2.Models.Author> Author { get; set; }

        public DbSet<Bianca_Teodora_Lab2.Models.Category> Category { get; set; }
    }
}
