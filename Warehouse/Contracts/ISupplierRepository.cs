using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Contracts
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        public void Delete(Supplier entity)
        {
            throw new NotImplementedException();
        }

        public IList<Supplier> Find(Expression<Func<Supplier, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Supplier Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Supplier> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Supplier entity)
        {
            throw new NotImplementedException();
        }
    }
}
