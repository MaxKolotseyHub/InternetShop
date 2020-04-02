using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private readonly DatabaseContext db;

        public CategoryRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Add(Category item)
        {
            db.Categories.Add(item);
        }

        public void Delete(int Id)
        {
            var i = db.Categories.FirstOrDefault(c => c.Id == Id);
            if (i != null)
                db.Categories.Remove(i);
        }

        public IList<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public Category GetItemById(int Id)
        {
            return db.Categories.FirstOrDefault(c => c.Id == Id);
        }

        public void Update(Category item)
        {
            //var i = db.Categories.FirstOrDefault(c => c.Id == item.Id);
            //if (i != null)
            //{
            //    db.Categories.Attach(i);
            //    i.Products = item.Products;
            //    //i.ProductId = item.ProductId;
            //    i.Title = item.Title;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;

            //}
        }
    }
}
