using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Repositories
{
    public class PurchaseRepository : IRepository<Purchase>
    {
        private readonly DatabaseContext db;

        public PurchaseRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Add(Purchase item)
        {
            db.Purchases.Add(item);
        }

        public void Delete(int Id)
        {
            var i = db.Purchases.FirstOrDefault(d => d.Id == Id);
            if (i != null)
                db.Purchases.Remove(i);
        }

        public IList<Purchase> GetAll()
        {
            return db.Purchases.ToList();
        }

        public Purchase GetItemById(int Id)
        {
            return db.Purchases.FirstOrDefault(d => d.Id == Id);
        }

        public void Update(Purchase item)
        {
            var i = db.Purchases.FirstOrDefault(c => c.Id == item.Id);

            if (i != null)
            {
                db.Purchases.Attach(i);
                i.DateTime = item.DateTime;
                i.Client = item.Client;
            }
        }
    }
}
