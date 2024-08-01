using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Contracts;
using Warehouse.Models;
using Microsoft.EntityFrameworkCore;

namespace Warehouse.Persistance
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        private readonly KioskDbContext _kioskDbContext;
        public SupplierRepository(KioskDbContext context)
        : base(context)
        {
            _kioskDbContext = context;
        }

        public IEnumerable<Supplier> GetSuppliersWithProducts()
        {
            return _kioskDbContext.Suppliers
                .Include(s => s.Products)
                .ToList();
        }
    }
}
