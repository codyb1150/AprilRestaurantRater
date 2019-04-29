using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRaterMVC.Models
{
    
    public class Restaurant
    {
        public int RestaurantID { get; set; }
        public int Name { get; set; }
        public int Address { get; set; }
        public int Rating { get; set; }
    }

    public class RestaurantDBContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}