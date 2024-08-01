using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Contracts
{
    public interface ICategoryRepository : IRepository<Category>
    {
        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public IList<Category> Find(System.Linq.Expressions.Expression<Func<Category, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Category Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IList<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Insert(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
