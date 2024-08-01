using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Contracts
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> Find(Expression<Func<Customer, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
