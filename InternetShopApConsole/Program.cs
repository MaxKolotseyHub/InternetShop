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
            var prod = unitOfWork.Products.GetAll();
            Console.WriteLine($"Название: {prod.First().Title}");
            Console.WriteLine($"Цена: {prod.First().Price}");
            Console.WriteLine($"Картинка: {prod.First().Images.First().Path}");
            Console.WriteLine($"Производитель: {prod.First().Producer.Country} {prod.First().Producer.Name}");
            Console.ReadKey();
        }
    }
}
