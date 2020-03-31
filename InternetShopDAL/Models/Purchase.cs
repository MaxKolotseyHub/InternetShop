using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Models
{
    public class Purchase
    {
        public Purchase()
        {
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
