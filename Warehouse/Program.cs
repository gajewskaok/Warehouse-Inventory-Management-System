using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Contracts;
using Warehouse.Persistance;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {
            // baza danych SQLite
            // wymagana instalacja pakietu Microsoft.EntityFrameworkCore.Sqlite
            var sqliteConnectionString = "Data Source=EntityFrameworkRepository.db";
            var options = new DbContextOptionsBuilder<KioskDbContext>()
                .UseSqlite(sqliteConnectionString)
                .Options;

            //using (var unitOfWork = new KioskUnitOfWork(new KioskDbContext(options)))
            //{
            //    // To Do: tutaj umiescic kod testujący

            //}

            //builder.Services.AddScoped<IProductRepository, ProductRepository>();
            //builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            //builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
            //builder.Services.AddScoped<IInventoryRepository, InventoryRepository>();
            //builder.Services.AddScoped<IOrderRepository, OrderRepository>();
            //builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
        }
    }
}
