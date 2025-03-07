//using Microsoft.AspNetCore.Mvc;
//using SampleApi.Model;
//using SampleApi.WebFramework.ApiHelper;

//namespace SampleApi.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class ProductsController : ControllerBase
//    {
//        public ProductsController()
//        {
//        }


//        [HttpGet("[action]")]
//        public async Task<IActionResult> Find(int id)
//        {
//            Product model = new Product
//            {
//                Id = 1,
//                Name = "Laptop"
//            };

//            var result = new ApiResult<Product>
//            {
//                IsSuccess = true,
//                Data = model
//            };
//            return Ok(result);
//        }


//        [HttpGet("[action]")]
//        public async Task<IActionResult> GetAll()
//        {
//            var products = new List<Product>()
//                {
//                    new Product
//                    {
//                        Id = 1,
//                        Name = "Laptop"
//                    }
//                };

//            var result = new ApiResult<List<Product>>
//            {
//                IsSuccess = true,
//                Data = products
//            };
//            return Ok(result);
//        }

//        [HttpGet("[action]")]
//        public async Task<IActionResult> Get(int id)
//        {
//            Product model = new Product
//            {
//                Id = 1,
//                Name = "Laptop"
//            };
//            var result = new ApiResult<Product>
//            {
//                IsSuccess = true,
//                Data = model
//            };
//            return Ok(result);
//        }

//        [HttpPost("add-product")]
//        public async Task<IActionResult> Add(Product model)
//        {
//            var result = new ApiResult<int>
//            {
//                IsSuccess = true,
//                Message = "my message"
//            };
//            try
//            {
//                throw new Exception("asdasdasd");
//                result.Data = 5;

//            }
//            catch (Exception e)
//            {

//                result.IsSuccess = false;
//            }
//            return Ok(result);
//        }

//        [HttpPost("edit-product")]
//        public async Task<IActionResult> Edit(Product model)
//        {
//            var result = new ApiResult
//            {
//                IsSuccess = true
//            };
//            return Ok(result);
//        }

//    }
//}
