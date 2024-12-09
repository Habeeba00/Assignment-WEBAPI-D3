using Assignment_WEBAPI_D3.DTOs.CatalogDTO;
using Assignment_WEBAPI_D3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_WEBAPI_D3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        ProductContext db;
        public CatalogController(ProductContext db) 
        {
            this.db = db;
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            List<Catalog> catalogs=db.Catalog.ToList();
            List<DisplayCatalogDTO> catalogDTOs=new List<DisplayCatalogDTO>();
            foreach (Catalog catalog in catalogs) 
            {
                DisplayCatalogDTO CatalogDTO = new DisplayCatalogDTO() 
                {
                    Id= catalog.Id,
                    Name = catalog.Name,
                    Description = catalog.Description,
                    ProductsName= catalog.products.Select(n => n.Name).ToList()
                };
                catalogDTOs.Add(CatalogDTO);

            }
            return Ok(catalogDTOs);
        }


        [HttpGet("{id}")]
        public IActionResult GetById(int id) 
        {
            Catalog c=db.Catalog.Where(n=>n.Id ==id).FirstOrDefault();
            if (c == null) return NotFound();
            else
            {
                DisplayCatalogDTO catalogDTO = new DisplayCatalogDTO() 
                { 
                    Id = c.Id,
                    Name = c.Name,
                    Description = c.Description,
                    ProductsName=c.products.Select(n=>n.Name).ToList()
                };
                return Ok(catalogDTO);
            }

        
        }

        [HttpPost]
        public ActionResult Add(AddCatalogDTO CatalogDTO) 
        {
            Catalog c = new Catalog() 
            {
                Name = CatalogDTO.Name,
                Description = CatalogDTO.Description,
            };
            db.Catalog.Add(c);
            db.SaveChanges();
            return Ok(c);


        }
       
    }
}
