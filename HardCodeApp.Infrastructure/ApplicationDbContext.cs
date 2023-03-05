using HardCodeApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HardCodeApp.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductField> ProductFields { get; set; }
    }
}
