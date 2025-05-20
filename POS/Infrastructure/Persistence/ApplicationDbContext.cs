using Microsoft.EntityFrameworkCore;
using POS.Domain.Entities.ConfigurationAndOthers;
using POS.Domain.Entities.Inventory;
using POS.Domain.Entities.MasterData;
using POS.Domain.Entities.ReportsAndLogs;
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

        //Transaction Data
        public DbSet<Sales> Sales { get; set; }
        public DbSet<SalesDetail> SaleDetails { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseDetail> PurchaseDetails { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Invoice> Invoices { get; set; }

        //Inventory Data
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<StockAdjustment> StockAdjustments { get; set; }
        public DbSet<StockTransfer> StockTransfers { get; set; }

        //Reports and Logs
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<SalesReport> SalesReports { get; set; }
        public DbSet<PurchaseReport> PurchaseReports { get; set; }
        public DbSet<InventoryReport> InventoryReports { get; set; }

        //Configuration Data
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

        //If Entities have no key, you can use the following method to configure them
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InventoryReport>().HasNoKey();
            modelBuilder.Entity<SalesReport>().HasNoKey();
            modelBuilder.Entity<PurchaseReport>().HasNoKey();
        }

    }
}
