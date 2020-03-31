using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Models
{
    public class Product
    {
        public Product()
        {
            Images = new List<Image>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string Description{ get; set; }
        public int ProducerId { get; set; }
        public long Count { get; set; }
        public virtual Category Category { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual List<Image> Images { get; set; }
    }
}
