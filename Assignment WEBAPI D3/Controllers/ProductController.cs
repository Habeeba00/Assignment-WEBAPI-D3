using Assignment_WEBAPI_D3.DTOs.ProductDTO;
using Assignment_WEBAPI_D3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_WEBAPI_D3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductContext db;
        public ProductController(ProductContext db) 
        {
            this.db = db;
        }
        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Product> products = db.Product.ToList();
            List<DisplayProductDTO> displayProductDTOs = new List<DisplayProductDTO>();
            foreach ( Product p in  products)
            {
                DisplayProductDTO displayProductDTO = new DisplayProductDTO() 
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    Catlog_Name = p.catalog.Name
                };
                displayProductDTOs.Add(displayProductDTO);

            }
            return Ok(displayProductDTOs);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            Product p = db.Product.Where(n => n.Id == id).FirstOrDefault();
            if (p == null) return NotFound();
            else 
            {
                DisplayProductDTO productDTO = new DisplayProductDTO()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Quantity = p.Quantity,
                    Catlog_Name = p.catalog.Name

                };
                return Ok(productDTO);


            }

        }


        [HttpPost]
        public IActionResult Add(AddProductDTO ProductDTO) 
        {
            Product p = new Product() 
            {
                Name = ProductDTO.Name,
                Price = ProductDTO.Price,
                Quantity = ProductDTO.Quantity,
                Catlog_Id=ProductDTO.Catlog_Id
            };
            db.Product.Add(p);
            db.SaveChanges();
            return Ok(p);
        }


    }
}
