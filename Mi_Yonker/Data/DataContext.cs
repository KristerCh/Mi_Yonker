using Microsoft.EntityFrameworkCore;
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
<<<<<<< HEAD
            optionsbuilder.UseSqlServer(@"Server=JAMF\LOCALSERVER;Database=MiYonker;Trusted_Connection=True;");
=======
            optionsbuilder.UseSqlServer(@"Server=DESKTOP-P1J30VH;Database=MiYonker;Trusted_Connection=True;");
>>>>>>> StoreController_29-08-2020
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
