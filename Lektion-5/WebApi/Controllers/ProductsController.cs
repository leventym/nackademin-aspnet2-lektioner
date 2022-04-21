using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IDataAccess _dataAccess;

        public ProductsController(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _dataAccess.GetAllProductsAsync();
            return new OkObjectResult(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(ProductRequest request)
        {
            var product = await _dataAccess.CreateProductAsync(request);
            if (product != null)
                return new OkObjectResult(product);

            return new BadRequestResult();
        }
    }
}
