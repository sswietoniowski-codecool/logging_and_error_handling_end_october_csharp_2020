using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using logging.Entities;

namespace logging.Data
{
    public interface IProductRepository
    {
        public List<Product> GetAllProducts();
    }
}
