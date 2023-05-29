using Microsoft.AspNetCore.Mvc;
using ProductsAPI.Data;
using ProductsAPI.Models;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET: api/Products
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        private readonly ProductsContext _PContext;
        public ProductsController(ProductsContext PContext)
        {
            _PContext = PContext;
        }

        // GET api/Products/
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Products
        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            try
            {
                _PContext.Products.Add(product);
                _PContext.SaveChanges();
                return Ok("Product Created Successfully");
            }

            catch(Exception ex)
            {
                return StatusCode(500, $"An error occured: {ex.Message}");
            }
        }

        // PUT api/Products/
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Products/
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
