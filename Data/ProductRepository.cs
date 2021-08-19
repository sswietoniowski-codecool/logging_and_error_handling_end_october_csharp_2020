using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using logging.Entities;
using Microsoft.Extensions.Logging;

namespace logging.Data
{
    public class ProductRepository : IProductRepository
    {
        private ILogger<ProductRepository> _logger;

        public ProductRepository(ILogger<ProductRepository> logger)
        {
            _logger = logger;
        }

        public List<Product> GetAllProducts()
        {
            _logger.LogDebug($"{nameof(GetAllProducts)}: Retrieving all products...");

            var products = new List<Product>()
            {
                new Product {Id = 1, Name = "Product A", Price = 10},
                new Product {Id = 2, Name = "Product B", Price = 20},
                new Product {Id = 3, Name = "Product C", Price = 30}
            };

            _logger.LogDebug($"{nameof(GetAllProducts)}: Retrieved all products");

            return products;
        }
    }
}
