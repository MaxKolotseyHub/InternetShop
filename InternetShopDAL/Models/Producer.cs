using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Models
{
    public class Producer
    {
        [Key, ForeignKey("Product")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public virtual Product Product { get; set; }
    }
}
