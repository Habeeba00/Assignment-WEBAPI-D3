using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Assignment_WEBAPI_D3.Models
{
    public class Catalog
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }
        public virtual List<Product> products { get; set; } = new List<Product>();


    }
}
