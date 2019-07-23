using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class DbTestContext:DbContext
    {
        public DbTestContext():base("CS")
        {           
           
        }

        public virtual DbSet<Dodavatel> Dodavatel { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OrderItem>()
            .HasOptional<Product>(s => s.Product)
            .WithMany()
            .WillCascadeOnDelete(true);

            modelBuilder.Entity<OrderItem>()
            .HasOptional<Order>(s => s.Order)
            .WithMany()
            .WillCascadeOnDelete(true);

            modelBuilder.Entity<Product>()
            .HasOptional<Dodavatel>(s => s.Dodavatel)
            .WithMany()
            .WillCascadeOnDelete(true);
        }


    }
}
