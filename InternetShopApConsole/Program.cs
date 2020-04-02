using InternetShopBLL.Interfaces;
using InternetShopBLL.Models;
using InternetShopBLL.Services;
using InternetShopDAL;
using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
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
            Dictionary<Product, int> cart = new Dictionary<Product, int>();

            IUnitOfWork unitOfWork = new UnitOfWork("Default");

            IProductService productService = new ProductService(unitOfWork);
            IPurchaseService purchaseService = new PurchaseService(unitOfWork, productService);

            var products = productService.GetAllProducts();

            Console.WriteLine("\tСписок товаров");
            Console.WriteLine("------------------------");

            products.ForEach(x =>
            Console.WriteLine($"{x.Id}. {x.Title} {x.Count} шт.")
            );

            Console.WriteLine("------------------------");
            Console.WriteLine("Что добавить в корзину?");

            while (true)
            {
                while (true)
                {
                    int count = 0;

                    Product product = null;
                    var key = Convert.ToInt32(Console.ReadLine());
                    if ((product = products.FirstOrDefault(x => x.Id == key)) == null)
                        Console.WriteLine("Неверный номер. Попробуйте еще раз.");
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("------------------------");
                            Console.WriteLine("Введите количество:");
                            count = Convert.ToInt32(Console.ReadLine());
                            if (product.Count < count)
                                Console.WriteLine("Слишком много. Попробуйте еще раз.");
                            else
                            {
                                break;
                            }
                        }

                        Console.WriteLine("Добавлено");
                        cart.Add(product, count);
                        break;
                    }
                }
                Console.WriteLine("------------------------");
                Console.WriteLine("Желаете купить что-нибудь еще? (y/n)");
                if (Console.ReadLine() == "n")
                    break;
                else continue;

            }

            var client = new Client
            {
                Adress = "Не дом и не улица",
                FirstName = "Макси",
                LastName = "Слав",
                MobilePhoneNumber = "+375259630794",
                Id = 1
            };

            purchaseService.CreatePurchase(cart, client);

            products = productService.GetAllProducts();

            Console.WriteLine("\tСписок товаров");
            Console.WriteLine("------------------------");

            products.ForEach(x =>
            Console.WriteLine($"{x.Id}. {x.Title} {x.Count} шт.")
            );

            Console.ReadKey();
        }
    }
}
