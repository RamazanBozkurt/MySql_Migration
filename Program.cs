using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Yeni_konsol
{
    class Program
    {
        public class ShopContext : DbContext 
        {
            public DbSet<Product> Products { get; set; }
            public DbSet<Category> Categories { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseMySql("server=localhost; port=3306; database=ShopDb; user=root; password=132");
            }
        }
        public class Product 
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
        }

        public class Category
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
