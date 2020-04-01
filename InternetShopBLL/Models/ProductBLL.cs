using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopBLL.Models
{
    public class ProductBLL
    {
        public ProductBLL()
        {
            Images = new List<ImageBLL>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public int ProducerId { get; set; }
        public long Count { get; set; }
        public virtual CategoryBLL Category { get; set; }
        public virtual ProducerBLL Producer { get; set; }
        public virtual List<ImageBLL> Images { get; set; }
    }
}
