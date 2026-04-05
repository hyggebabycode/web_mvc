using Microsoft.EntityFrameworkCore;
using BTL_WEB.Models;
namespace BTL_WEB.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Ví dụ table
        public DbSet<Product> Products { get; set; }
    }
}