using AutoMapper;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Services.DataAccess
{
    public class MsSqlDataAccess : IDataAccess
    {
        private readonly MsSqlContext _context;
        private readonly IMapper _mapper;

        public MsSqlDataAccess(MsSqlContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<Product> CreateProductAsync(ProductCreateRequest data)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
