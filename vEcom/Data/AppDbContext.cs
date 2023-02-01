using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vEcom.Models;

namespace vEcom.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product_Categories>().HasKey(pc => new
            {
                pc.ProductId,
                pc.CategoryId
            });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Brands> vEcom_Brands {get; set;}
        public DbSet<Categories> vEcom_Category { get; set; }
        public DbSet<Colors> vEcom_Color { get; set; }
        public DbSet<Product_Categories> vEcom_Product_Category { get; set; }
        public DbSet<Products> vEcom_Product { get; set; }
        public DbSet<Vehicles> vEcom_Vehicle { get; set; }
        public DbSet<VehModels> vEcom_VehModel { get; set; }

    }
}
