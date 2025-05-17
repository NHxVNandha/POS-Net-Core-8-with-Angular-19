using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities.MasterData;
using POS.Domain.Entities.Transactions;

namespace POS.Infrastructure.Persistence
{
    public class POSDbContext : DbContext
    {
        public POSDbContext(DbContextOptions<POSDbContext> options) : base(options) { }

        //Master Data
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Tax> Taxes { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

        //Transaction Data
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

    }
}
