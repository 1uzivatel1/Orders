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
        public DbTestContext()
        {
            
            string cs = ConfigurationManager.ConnectionStrings["CS"].ConnectionString;
            SqlConnection con = new SqlConnection(cs);
           
        }

        public virtual DbSet<Dodavatel> Dodavatel { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<Order> Order { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

            //<add name = "WindowsFormsApp2.Properties.Settings.WindowsFormsApp2_DbTestContextConnectionString"
    }
}
