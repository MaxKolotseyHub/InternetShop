using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopBLL.Models
{
    public class ImageBLL
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public int ProductId { get; set; }
        public ProductBLL Product { get; set; }
    }
}
