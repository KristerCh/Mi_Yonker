using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mi_Yonker.Data
{
    public class DataContext : DbContext   
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(@"Server=KRISTER\MI_EQUIPO;Database=MiYonker");
        }

        public DbSet<Brands> brands { get; set; }
        public DbSet<Models>
    }
}
