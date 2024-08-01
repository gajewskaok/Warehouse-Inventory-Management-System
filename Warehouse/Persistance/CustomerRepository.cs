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
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        private readonly KioskDbContext _kioskDbContext;
        public CustomerRepository(KioskDbContext context)
        : base(context)
        {
            _kioskDbContext = context;
        }

        public Customer GetCustomerWithOrders(int customerId)
        {
            return _kioskDbContext.Customers
                .Include(c => c.Orders)
                .FirstOrDefault(c => c.Id == customerId);
        }
    }
}
