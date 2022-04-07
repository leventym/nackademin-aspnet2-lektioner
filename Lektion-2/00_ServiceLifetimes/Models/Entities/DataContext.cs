using Microsoft.EntityFrameworkCore;

namespace _00_ServiceLifetimes.Models.Entities
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions options) : base(options)
        {
        }
    }
}
