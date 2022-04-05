using _02_WebApi.Models;
using _02_WebApi.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace _02_WebApi.Services
{
    public interface IProductManager
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
    public class ProductManager : IProductManager
    {
        private readonly DataContext _context;

        public ProductManager(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var list = new List<Product>();

            foreach (var product in await _context.Products.ToListAsync())
            {
                list.Add(new Product { Id = product.Id, Name = product.Name, Price = product.Price });

                
            }

            return list;
        }
    }
}
