using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Contracts;
using Warehouse.Models;

namespace Warehouse.Persistance
{
    public class InventoryRepository : Repository<Inventory>, IInventoryRepository
    {
        private readonly KioskDbContext _kioskDbContext;
        public InventoryRepository(KioskDbContext context)
        : base(context)
        {
            _kioskDbContext = context;
        }


        public IEnumerable<Inventory> GetInventoryByProduct(int productId)
        {
            return _kioskDbContext.Inventories
                .Where(i => i.ProductId == productId)
                .ToList();
        }
    }
}
