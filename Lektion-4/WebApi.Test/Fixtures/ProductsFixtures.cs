using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Test.Fixtures
{
    public static class ProductsFixtures
    {
        public static List<Product> GetTestProducts() => new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 100},
            new Product { Id = 2, Name = "Product 1", Price = 100},
            new Product { Id = 3, Name = "Product 1", Price = 100}
        };

    }
}
