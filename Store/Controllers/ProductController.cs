using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Store.Data;
using Store.Entities;

namespace Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly DatabaseContext context;
        public ProductController(
            DatabaseContext _context) { 
            context = _context;
        }
        

        [HttpGet("product")]
        public IEnumerable<Product> GetProducts()
        {
            var products = (from p in context.Product select p).ToList();
            return products;
        }

        [HttpPost("product")]
        public Product PostProducts([FromBody] Product newProduct)
        {
            context.Product.Add(newProduct);
            context.SaveChanges();
            return newProduct;
        }

        [HttpPut("product")]
        public Product UpdateProducts([FromBody] Product newProduct)
        {
            var oldProduct = (from p in context.Product where p.Id == newProduct.Id select p).FirstOrDefault();
            oldProduct.Name = newProduct.Name;
            oldProduct.Price = newProduct.Price;

            context.SaveChanges();
            return newProduct;
        }

        [HttpDelete("product/{id}")]
        public int DeleteProduct(int id)
        {
            var oldProduct = (from p in context.Product where p.Id == id select p).FirstOrDefault();

            if(oldProduct != null)
            {
                context.Product.Remove(oldProduct);
                context.SaveChanges();
            }
            return id;
        }





    }
}
