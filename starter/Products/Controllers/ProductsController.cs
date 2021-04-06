using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static List<Product> _products = new();

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _products;
        }

        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Product product)
        {
            _products.Add(product);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            var existingProduct = _products.FirstOrDefault(p => p.Id == id);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            _products.Remove(product);
        }
    }
}
