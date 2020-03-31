using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Repositories
{
    public class DescriptionRepository : IRepository<Description>
    {
        private readonly DatabaseContext db;

        public DescriptionRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Add(Description item)
        {
            db.Descriptions.Add(item);
        }

        public void Delete(int Id)
        {
            var i = db.Descriptions.FirstOrDefault(d => d.Id == Id);
            if (i != null)
                db.Descriptions.Remove(i);
        }

        public IList<Description> GetAll()
        {
            return db.Descriptions.ToList();
        }

        public Description GetItemById(int Id)
        {
            return db.Descriptions.FirstOrDefault(d => d.Id == Id);
        }

        public void Update(Description item)
        {
            var i = db.Descriptions.FirstOrDefault(c => c.Id == item.Id);
            if (i != null)
            {
                i.Product = item.Product;
                //i.ProductId = item.ProductId;
                i.Text = item.Text;
            }
        }
    }
}
