using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Product> Products { get; set; }

        public DatabaseContext(string connectionString) : base(connectionString)
        {

        }

        static DatabaseContext()
        {
            Database.SetInitializer<DatabaseContext>(new DbInitializer());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Producer>()
                .HasMany(p => p.Products)
                .WithRequired(p => p.Producer);

            modelBuilder.Entity<Product>()
                .HasMany(p => p.Images)
                .WithRequired(p => p.Product);


        }
    }
}
