using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Contracts
{
    public interface IInventoryRepository : IRepository<Inventory>
    {
        public void Delete(Inventory entity)
        {
            throw new NotImplementedException();
        }

        public IList<Inventory> Find(Expression<Func<Inventory, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Inventory Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Inventory> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Inventory entity)
        {
            throw new NotImplementedException();
        }
    }
}
