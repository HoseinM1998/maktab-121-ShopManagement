using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Memory;
using ShopManagement.Domain.Contracts;
using ShopManagement.Domain.Entities;

namespace ShopManagement.AppServices
{
    public class ProductAppServices : IProductAppServices
    {
        private readonly IProductRepository _productRepository;
        private readonly IMemoryCache _memoryCache;
        private readonly IDistributedCache _distributedCache;

        public ProductAppServices(
            IProductRepository productRepository,
            IMemoryCache memoryCache,
            IDistributedCache distributedCache)
        {
            _productRepository = productRepository;
            _memoryCache = memoryCache;
            _distributedCache = distributedCache;
        }

        public async Task<List<Product>> GetListOfProducts()
        {
            List<Product> products;
            if (_memoryCache.Get("ProductList") is not null)
            {
                products = _memoryCache.Get<List<Product>>("ProductList");
            }
            else
            {
                products = await _productRepository.GetProducts();
                _memoryCache.Set("ProductList", products, TimeSpan.FromSeconds(10));

                //_memoryCache.Set("ProductList", products, 
                //    new MemoryCacheEntryOptions
                //    {
                //        SlidingExpiration = TimeSpan.FromSeconds(5)
                //    });
            }
            return products;
        }

        public Product GetProductDetails(int productId)
        {
            var a = 5;
            return _productRepository.GetProductDetails(productId);
        }


        public int AddProducts(string name, int price, int quantity, int userId)
        {
            // validate
           return _productRepository.AddProducts(name, price, quantity, userId);
        }

        public void EditProducts(int id, string name, int price, int quantity, int userId)
        {
            _productRepository.EditProducts(id, name, price, quantity, userId);
        }
    }
}
