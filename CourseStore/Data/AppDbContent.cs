using CourseStore.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseStore.Data
{
    public class AppDbContent:DbContext
    {
        public AppDbContent(DbContextOptions<AppDbContent> options):base(options)
        {

        }



        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<StoreProductItem> StoreProductItems { get; set; }

        public DbSet<Order> order { get;set; }
        public DbSet<OrderDetail> orderDetail { get;set; }

    }
}
