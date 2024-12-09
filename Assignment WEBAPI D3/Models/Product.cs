using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_WEBAPI_D3.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("catalog")]
        public int Catlog_Id { get; set; }
        public virtual Catalog catalog { get; set; }

    }
}
