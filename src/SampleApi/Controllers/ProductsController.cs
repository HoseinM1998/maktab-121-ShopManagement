using Microsoft.AspNetCore.Mvc;
using SampleApi.Model;
using SampleApi.WebFramework.ApiHelper;
using ShopManagement.Framework.CustomExceptions;

namespace SampleApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [ApiResultFilter]
    [ApiResultExceptionFilter]
    public class ProductsController : ControllerBase
    {
        public ProductsController()
        {
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> Find(int id)
        {
            Product model = new Product
            {
                Id = 1,
                Name = "Laptop"
            }; 
            return Ok(model);
        }


        [HttpGet("[action]")]
        public async Task<IActionResult> GetAll()
        {
            var products = new List<Product>()
                {
                    new Product
                    {
                        Id = 1,
                        Name = "Laptop"
                    }
                };
            return Ok(products);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> Get(int id)
        {
            Product model = new Product
            {
                Id = 1,
                Name = "Laptop"
            };

            //return Ok();
            return Ok(model);
            //return NotFound();
            //return NotFound(result);
        }

        [HttpPost("add-product")]
        public async Task<IActionResult> Add(Product model)
        {
            throw new Exception();
            return Ok(5);
        }

        [HttpPost("edit-product")]
        public async Task<IActionResult> Edit(Product model)
        {
            // AppService -- db commands
            throw new NotFoundException();
            return Ok();
        }

    }
}
