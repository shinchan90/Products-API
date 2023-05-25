using Microsoft.AspNetCore.Mvc;

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

        // GET api/Products/
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/Products
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
