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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly Mapper mapper;

        public ProductService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
            mapper = AutoMapperConfig.GetMapper();
        }

        public void BuyProduct(int Id, long Count)
        {
            var product = unitOfWork.Products.GetItemById(Id);
            product.Count -= Count;
            unitOfWork.Products.Update(mapper.Map<Product>(product));
        }

        public List<Product> GetAllProducts()
        {
            return (List<Product>) unitOfWork.Products.GetAll();
        }

        public Product GetProduct(int Id)
        {
            return unitOfWork.Products.GetItemById(Id);
        }
    }
}
