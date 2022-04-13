using _00_ServiceLifetimes.Models;
using _00_ServiceLifetimes.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _00_ServiceLifetimes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;

        public CustomersController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return new OkObjectResult(await customerService.GetAllAsync<Customer>());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var item = await customerService.GetAsync<Customer>(id);
            if(item == null)
            {
                return new NotFoundResult();
            }
            return new OkObjectResult(item);
        }
    }
}
