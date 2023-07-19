using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class ShopMVCDbContext:DbContext
    {

        public ShopMVCDbContext() { Database.EnsureCreated(); }
        //public ShopMVCDbContext(DbContextOptions<ShopMVCDbContext> options):base(options) {
        //    //Database.EnsureDeleted();
        //   // Database.EnsureCreated();
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder options) { 
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ShopMVC;Integrated Security=True;"); 
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; } 

    }
}
