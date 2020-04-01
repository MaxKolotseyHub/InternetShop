using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopBLL.Models
{
    public class PurchaseBLL
    {
        public PurchaseBLL()
        {
            Products = new List<ProductBLL>();
        }
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int ClientId { get; set; }
        public virtual ClientBLL Client { get; set; }
        public virtual List<ProductBLL> Products { get; set; }
    }
}
