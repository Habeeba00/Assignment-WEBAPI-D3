using Assignment_WEBAPI_D3.Models;

namespace Assignment_WEBAPI_D3.DTOs.CatalogDTO
{
    public class DisplayCatalogDTO
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public string Description { get; set; }
        public virtual List<string> ProductsName { get; set; } = new List<string>();
    }
}
