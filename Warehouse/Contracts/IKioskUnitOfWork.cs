using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Contracts
{
    public interface IKioskUnitOfWork : IDisposable
    {
        IProductRepository ProductRepository { get; }
        IOrderRepository OrderRepository { get; }
        ISupplierRepository SupplierRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IInventoryRepository InventoryRepository { get; }
        void Commit();
    }
}
