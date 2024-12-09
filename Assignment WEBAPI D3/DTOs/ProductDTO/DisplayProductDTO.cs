using Assignment_WEBAPI_D3.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_WEBAPI_D3.DTOs.ProductDTO
{
    public class DisplayProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Catlog_Name { get; set; }

    }
}
