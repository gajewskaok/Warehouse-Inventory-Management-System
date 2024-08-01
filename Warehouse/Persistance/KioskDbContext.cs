using Microsoft.EntityFrameworkCore;
using Warehouse.Models;
using Warehouse.Persistance.EntityConfiguration;

namespace Warehouse.Persistance
{
    public class KioskDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public KioskDbContext(DbContextOptions<KioskDbContext> options)
        : base(options)
        {
            // Database.EnsureCreated() sprawdza, czy baza danych istnieje.
            // Jeśli tak - nic nie robi.
            // Jeśli nie - tworzy bazę i tabele zgodnie z modelem.
            // UWAGA: Gdy baza istnieje, nie jest sprawdzane, czy jest zgodna z modelem.
            // Aby zagwarantować zgodność bazy z modelem, można rozważyć sekwencję instrukcji:
            // Database.EnsureDeleted();
            // Database.EnsureCreated();
            // Powoduje to jednak zawsze usuwanie bazy przed rozpoczęciem działania programu.
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new SupplierConfiguration());
            builder.ApplyConfiguration(new InventoryConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new CustomerConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
