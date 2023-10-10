using System.Reflection.Metadata;
using FIAP.TechChallenge.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FIAP.TechChallenge.Infrastructure.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options)
        : base(options) { }


        public DbSet<Customer> Customer { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
