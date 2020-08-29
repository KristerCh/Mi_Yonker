﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mi_Yonker.Modelos;

namespace Mi_Yonker.Data
{
    public class DataContext : DbContext   
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer(@"Server=LAPTOP-IN84HPHT\SQL;User=sa;Password=Hola1234;Database=MiYonker");
        }

        public DbSet<Brands> brands { get; set; }
        public DbSet<Models> models { get; set; }
        public DbSet<Partlist> partlist { get; set; }
        public DbSet<Partlist_details> partlist_Details { get; set; }
        public DbSet<Parts_vehicle> parts_Vehicles { get; set; }
        public DbSet<Stores> stores { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<Vehicles> vehicles { get; set; }
        public DbSet<Vehicles_stores> vehicles_Stores { get; set; }

    }
}
