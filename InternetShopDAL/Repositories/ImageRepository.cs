using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Repositories
{
    public class ImageRepository : IRepository<Image>
    {
        private readonly DatabaseContext db;

        public ImageRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Add(Image item)
        {
            db.Images.Add(item);
        }

        public void Delete(int Id)
        {
            var i = db.Images.FirstOrDefault(x => x.Id == Id);
            if (i != null)
                db.Images.Remove(i);
        }

        public IList<Image> GetAll()
        {
            return db.Images.ToList();
        }

        public Image GetItemById(int Id)
        {
            return db.Images.FirstOrDefault(x => x.Id == Id);
        }

        public void Update(Image item)
        {
            //var i = db.Images.FirstOrDefault(c => c.Id == item.Id);
            //if (i != null)
            //{
            //    db.Images.Attach(i);
            //    i.Product = item.Product;
            //    //i.ProductId = item.ProductId;
            //    i.Path = item.Path;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;

            //}
        }
    }
}
