using Ecom.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext( DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}
