using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebApi.Models;

namespace SalesWebApi.Models {
    public class AppDbContext : DbContext {

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderLine> OrderLines { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder) { 
        }

        public DbSet<SalesWebApi.Models.Order> Order { get; set; }
    }
}
