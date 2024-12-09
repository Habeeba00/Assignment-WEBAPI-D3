using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment_WEBAPI_D3.DTOs.ProductDTO
{
    public class AddProductDTO
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Catlog_Id { get; set; }
    }
}
