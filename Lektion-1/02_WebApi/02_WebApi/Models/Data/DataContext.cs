using _02_WebApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _02_WebApi.Models.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public virtual DbSet<ProductEntity> Products { get; set; } = null!;
    }
}