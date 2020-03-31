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
        IRepository<Description> Descriptions { get; }
        IRepository<Image> Images { get; }
        IRepository<Producer> Producers { get; }
        IRepository<Product> Products { get; }
        void Save();
    }
}
