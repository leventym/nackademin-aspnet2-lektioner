using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {

        }


        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            return new OkObjectResult("");
        }
    }
}
