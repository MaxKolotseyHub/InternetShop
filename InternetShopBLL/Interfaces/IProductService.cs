using InternetShopBLL.Models;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopBLL.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Product GetProduct(int Id);
        void BuyProduct(int Id, long Count);
        List<Category> GetAllCategories();
        List<Product> GetProductsInCategory(int Id);
    }
}
