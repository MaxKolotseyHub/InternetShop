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
            //Images = new List<Images>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int ProducerId { get; set; }
        public int DescriptionId { get; set; }
        public int CategoryId { get; set; }
        public long Count { get; set; }
        public virtual Category Category { get; set; }
        public virtual Description Description { get; set; }
        public virtual Producer Producer { get; set; }
        public virtual Image Images { get; set; }
    }
}
