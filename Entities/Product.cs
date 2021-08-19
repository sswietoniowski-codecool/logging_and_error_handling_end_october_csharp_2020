using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace logging.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"Id = {Id}, Name = '{Name}', Price = {Price}";
        }
    }
}
