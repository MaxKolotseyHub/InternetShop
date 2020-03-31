using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Category> Categories { get; }
        IRepository<Client> Clients { get; }
        IRepository<Purchase> Purchases { get; }
        IRepository<Image> Images { get; }
        IRepository<Producer> Producers { get; }
        IRepository<Product> Products { get; }
        void Save();
    }
}
