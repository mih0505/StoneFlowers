using ApplicationLayer.Interfaces;
using Domain.Common;
using Domain.OrderModels;
using Domain.ProductModels;
using Microsoft.EntityFrameworkCore;

namespace AccessLayer
{
    public class StoneFlowersDbContext : DbContext, IStoneFlowersDbContext
    {
        public StoneFlowersDbContext(DbContextOptions<StoneFlowersDbContext> options)
        : base(options)
        { }

        public DbSet<Department> Departments { get; set; } = null!;
        public DbSet<Organization> Organizations { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Customers { get; set; } = null!;
        public DbSet<OrderProduct> OrderProducts { get; set; } = null!;
        public DbSet<OrderType> OrderTypes { get; set; } = null!;
        public DbSet<Payment> Payments { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<CategoryProperty> CategoryProperties { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductParameter> ProductParameters { get; set; } = null!;
        public DbSet<Property> Properties { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            //DbInitializer.Initialize(modelBuilder);
        }
    }
}
