using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Contracts;

namespace Warehouse.Persistance
{
    public class KioskUnitOfWork : IKioskUnitOfWork
    {
        private readonly KioskDbContext _context;
        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public ICustomerRepository CustomerRepository { get; }
        public IInventoryRepository InventoryRepository { get; }
        public ISupplierRepository SupplierRepository { get; }

        public KioskUnitOfWork(KioskDbContext context)
        {
            this._context = context;
            this.ProductRepository = new ProductRepository(this._context);
            this.OrderRepository = new OrderRepository(this._context);
            this.CategoryRepository = new CategoryRepository(this._context);
            this.CustomerRepository = new CustomerRepository(this._context);
            this.InventoryRepository = new InventoryRepository(this._context);
            this.SupplierRepository = new SupplierRepository(this._context);
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
