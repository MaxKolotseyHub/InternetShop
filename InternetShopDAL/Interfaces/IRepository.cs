using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
        T GetItemById(int Id);
        void Update(T item);
        void Delete(int Id);
        void Add(T item);
    }
}
