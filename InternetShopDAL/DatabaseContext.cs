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
        public DbSet<Description> Descriptions { get; set; }
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
    }
}
