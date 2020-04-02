using InternetShopBLL.Models;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopBLL.Interfaces
{
    public interface IPurchaseService
    {
        void CreatePurchase(Dictionary<Product, int> CartProducts, Client client);
    }
}
