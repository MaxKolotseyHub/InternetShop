using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternetShopDAL.Models
{
    public class Image
    {
        [Key, ForeignKey("Product")]
        public int Id { get; set; }
        public string Path { get; set; }
        public virtual Product Product { get; set; }
    }
}
