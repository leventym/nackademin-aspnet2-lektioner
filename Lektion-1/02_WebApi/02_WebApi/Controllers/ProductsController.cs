using _02_WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _02_WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private List<Product> _products;
        public IEnumerable<Product> GetAll()
        {
            
            return _products;
        }

        public void Create(Product model)
        {
            _products.Add(model);
        }
    }
}
