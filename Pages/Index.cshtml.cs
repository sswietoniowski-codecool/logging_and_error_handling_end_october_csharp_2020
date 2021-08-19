using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using logging.Data;
using logging.Entities;

namespace logging.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private IProductRepository _productRepository;

        public List<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, IProductRepository productRepository)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("Called OnGet method...");

            Products = _productRepository.GetAllProducts();
        }
    }
}
