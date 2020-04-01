using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopBLL.Models
{
    public class ProducerBLL
    {
        public ProducerBLL()
        {
            Products = new List<ProductBLL>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public virtual List<ProductBLL> Products { get; set; }
    }
}
