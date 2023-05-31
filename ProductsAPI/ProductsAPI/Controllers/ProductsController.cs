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
        private readonly ProductsContext _PContext;
        
        
        public ProductsController(ProductsContext PContext)
        {
            _PContext = PContext;
        }

        [HttpGet]
        // GET: api/Products
        public IActionResult Get()
        {
            try
            {
                var Products = _PContext.Products.ToList();
                return Ok(Products);
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
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
        public IActionResult Update([FromRoute] int id, UpdateProduct update) 
        {
            var product = _PContext.Products.Find(id);
            if(product != null)
            {
                product.Name= update.Name;
                product.Description= update.Description;
                product.Price= update.Price;
                product.Quantity= update.Quantity;
                product.Availability= update.Availability;
                _PContext.SaveChanges();
                return Ok("Product Successfully Updated");
            }

            return NotFound();
        }

        // DELETE api/Products/
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            var product = _PContext.Products.Find(id);
            if(product!= null)
            {
                _PContext.Products.Remove(product);
                _PContext.SaveChanges();
                return Ok("Product Deleted Successfully");
            }

            return NotFound();
        }
    }
}
