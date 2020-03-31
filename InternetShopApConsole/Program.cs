using InternetShopDAL;
using InternetShopDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopApConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork unitOfWork = new UnitOfWork("Default");
            var prod = unitOfWork.Purchases.GetItemById(1);
            prod.Products.Clear();
            unitOfWork.Purchases.Update(prod);
            prod = unitOfWork.Purchases.GetItemById(1);

            Console.WriteLine($"Имя клиента: {prod.Client.FirstName}");
            Console.WriteLine($"Id заказа: {prod.Id}");
            Console.WriteLine($"Товаров в заказе: {prod.Products.Count}");
            Console.ReadKey();
        }
    }
}
