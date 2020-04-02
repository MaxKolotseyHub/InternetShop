using AutoMapper;
using InternetShopBLL.Helpers;
using InternetShopBLL.Interfaces;
using InternetShopBLL.Models;
using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopBLL.Services
{
    public class PurchaseService : IPurchaseService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly Mapper mapper;
        private readonly IProductService productService;
        public PurchaseService(IUnitOfWork unitOfWork, IProductService productService)
        {
            this.unitOfWork = unitOfWork;
            this.productService = productService;
            mapper = AutoMapperConfig.GetMapper();
        }
        public void CreatePurchase(Dictionary<Product, int> CartProducts, Client client)
        {
            foreach (var product in CartProducts)
            {
                productService.BuyProduct(product.Key.Id, product.Value);
            }

            var purchase = new Purchase {
                Client = client,
                DateTime = DateTime.Now,
                Products = CartProducts.Keys.ToList()
            };

            unitOfWork.Purchases.Add(purchase);

            unitOfWork.Save();
        }
    }
}
