using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopBLL.Models
{
    public class CategoryBLL
    {
        public CategoryBLL()
        {
            Products = new List<ProductBLL>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<ProductBLL> Products { get; set; }
    }
}
