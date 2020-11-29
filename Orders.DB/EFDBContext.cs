using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Orders.DB.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orders.DB
{
    public class EFDBContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Person> People { get; set; }
        public EFDBContext(DbContextOptions<EFDBContext> options) : base(options) { }

    }
    public class EFDBContextFactory : IDesignTimeDbContextFactory<EFDBContext>
    {
        public EFDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EFDBContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DeliveryOrders;Trusted_Connection=True;MultipleActiveResultSets=true", b => b.MigrationsAssembly("Orders.DB"));

            return new EFDBContext(optionsBuilder.Options);
        }
    }
}
