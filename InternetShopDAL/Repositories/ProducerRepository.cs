using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Repositories
{
    public class ProducerRepository : IRepository<Producer>
    {
        private readonly DatabaseContext db;

        public ProducerRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Add(Producer item)
        {
            db.Producers.Add(item);
        }

        public void Delete(int Id)
        {
            var i = db.Producers.FirstOrDefault(x => x.Id == Id);
            if (i != null)
                db.Producers.Remove(i);
        }

        public IList<Producer> GetAll()
        {
            return db.Producers.ToList();
        }

        public Producer GetItemById(int Id)
        {
            return db.Producers.FirstOrDefault(x => x.Id == Id);
        }

        public void Update(Producer item)
        {
            //var i = db.Producers.FirstOrDefault(c => c.Id == item.Id);
            //if (i != null)
            //{ 
            //    db.Producers.Attach(i);
            //    //i.ProductId = item.ProductId;
            //    i.Name = item.Name;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;

            //}
        }
    }
}
