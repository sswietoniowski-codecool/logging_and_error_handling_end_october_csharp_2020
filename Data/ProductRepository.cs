using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using logging.Entities;
using Microsoft.Extensions.Logging;

namespace logging.Data
{
    public static class RandomExtension
    {
        public static bool NextBool(this Random random, int truePercentage = 50)
        {
            return random.NextDouble() < (truePercentage / 100.0);
        }
    }

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

            Random random = new Random();

            if (random.NextBool())
            {
                var products = new List<Product>()
                {
                    new Product {Id = 1, Name = "Product A", Price = 10},
                    new Product {Id = 2, Name = "Product B", Price = 20},
                    new Product {Id = 3, Name = "Product C", Price = 30}
                };

                _logger.LogDebug($"{nameof(GetAllProducts)}: Retrieved all products");

                return products;
            }
            else
            {
                _logger.LogError(DataEvents.GetAllProducts, $"{nameof(GetAllProducts)}: Unable to retrieve all products");

                throw new Exception("ERROR: Unable to retrieve all products");
            }
        }
    }
}