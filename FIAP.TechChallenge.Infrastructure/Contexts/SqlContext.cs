﻿using FIAP.TechChallenge.Domain.Entities;
using FIAP.TechChallenge.Infrastructure.Mappings;
using Microsoft.EntityFrameworkCore;

namespace FIAP.TechChallenge.Infrastructure.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options)
        : base(options) { }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new ProductMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
