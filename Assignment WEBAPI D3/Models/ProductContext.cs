using Microsoft.EntityFrameworkCore;

namespace Assignment_WEBAPI_D3.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext()
        {
            
        }
        public ProductContext(DbContextOptions <ProductContext> option):base(option)
        {
            
        }
        public virtual DbSet<Product>Product { get; set; }
        public virtual DbSet<Catalog> Catalog {  get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=HABEEEEBA\\SQLEXPRESS;Database=Product;Trusted_connection=True;TrustServerCertificate=True;");
        //}
    }
}
