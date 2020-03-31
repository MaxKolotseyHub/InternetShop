using InternetShopDAL.Interfaces;
using InternetShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Repositories
{
    class ClientRepository : IRepository<Client>
    {
        private readonly DatabaseContext db;

        public ClientRepository(DatabaseContext db)
        {
            this.db = db;
        }

        public void Add(Client item)
        {
            db.Clients.Add(item);
        }

        public void Delete(int Id)
        {
            var i = db.Clients.FirstOrDefault(c => c.Id == Id);
            if (i != null)
                db.Clients.Remove(i);
        }

        public IList<Client> GetAll()
        {
            return db.Clients.ToList();
        }

        public Client GetItemById(int Id)
        {
            return db.Clients.FirstOrDefault(c=>c.Id==Id);
        }

        public void Update(Client item)
        {
            var i = db.Clients.FirstOrDefault(c => c.Id == item.Id);
            if (i != null)
            {
                db.Clients.Attach(i);
                i.LastName = item.LastName;
                i.MobilePhoneNumber = item.MobilePhoneNumber;
                i.FirstName = item.FirstName;
                i.Adress = item.Adress;
            };
        }
    }
}
