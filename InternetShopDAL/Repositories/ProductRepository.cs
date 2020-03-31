using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly DatabaseContext db;

        public ProductRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Add(Product item)
        {
            db.Products.Add(item);
        }

        public void Delete(int Id)
        {
            var i = db.Products.FirstOrDefault(x => x.Id == Id);
            if (i != null)
                db.Products.Remove(i);
        }

        public IList<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetItemById(int Id)
        {
            return db.Products.FirstOrDefault(x => x.Id == Id);
        }

        public void Update(Product item)
        {
            var i = db.Products.FirstOrDefault(c => c.Id == item.Id);
            if (i != null)
            {
                db.Products.Attach(i);

                i.Images = item.Images;
                i.Price = item.Price;
                i.Producer = item.Producer;
                i.ProducerId = item.ProducerId;
                i.Title = item.Title;
                i.Category = item.Category;
                i.Count = item.Count;
                i.Description = item.Description;
                //i.DescriptionId = item.DescriptionId;
            }
        }
    }
}
