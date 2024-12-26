using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_OOP_32._2
{
    internal class IrisContext:DbContext
    {
        public IrisContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Iris> Iris { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;" +
                "Username=postgres;Password=postgres");
        }
    }
}
