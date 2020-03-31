using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetShopDAL.Models
{
    public class Category
    {
        [Key, ForeignKey("Product")]
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual Product Product { get; set; }
    }
}