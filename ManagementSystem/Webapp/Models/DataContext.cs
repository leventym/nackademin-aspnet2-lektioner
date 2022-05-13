using Microsoft.EntityFrameworkCore;

namespace Webapp.Models
{
    public class DataContext : DbContext
    {

        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
