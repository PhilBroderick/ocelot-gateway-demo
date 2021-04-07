using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Basket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private static readonly List<BasketItem> _basket = new();

        [HttpGet]
        public IEnumerable<BasketItem> Get()
        {
            return _basket;
        }

        [HttpPost]
        public void Post([FromBody] BasketItem basketItem)
        {
            _basket.Add(basketItem);
        }

        [HttpDelete("{productId}")]
        public void Delete(int productId)
        {
            var basketItem = _basket.FirstOrDefault(b => b.ProductId == productId);
            _basket.Remove(basketItem);
        }
    }
}
