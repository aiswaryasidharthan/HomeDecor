using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myshop.Models

{
    public class AppDbContext :IdentityDbContext<IdentityUser>

    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {
            
        }

        ////Adding DB set of the products and categories////
        public DbSet<Shop> Products { get; set; }
        public DbSet<Category> categories { get; set; }

        ////Adding Database set of shoppingcart////
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

        //Adding database srt of Order details//
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
             base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Categoryid = 1,
                CategoryName = "Living and BedRoom"
            });

            modelBuilder.Entity<Category>().HasData(new Category
            {
                Categoryid = 2,
                CategoryName = "Kitchen and Home"
            });

            modelBuilder.Entity<Shop>().HasData(new Shop 

            { ShopId =1,
                Name = "Cozy sofa",
                Price =250.5M,
                Description = "This is a sandal wood imported from India, a state in kerala",
                CategoryId=1,
                ImageUrl = "  \\Images\\sofa3.jpg    ",
                ImageThumbnailUrl = "  \\Images\\sofa3.jpg    ",
                IsOnSale =true,
                OnStock =true
                

            });
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 2,
                Name = "Wood finish sofas",
                Price = 150.5M,
                Description = "This is a Rose wood imported from India, a state in kerala",
                CategoryId = 2,
                ImageUrl = "\\Images\\sofa2.jpg    ",
               ImageThumbnailUrl = "\\Images\\sofa2.jpg    ",
                IsOnSale = true,
                OnStock = true


            });
            modelBuilder.Entity<Shop>().HasData(new Shop

            {
                ShopId = 3,
                Name = "Recliner",
                Price = 110.5M,
                Description = "Write here",
                CategoryId = 2,
                ImageUrl = "  \\Images\\sofa4.jpg    ",
                ImageThumbnailUrl = "  \\Images\\sofa4.jpg    ",
                IsOnSale = true,
                OnStock = true


            });
        }

    }
    
}
