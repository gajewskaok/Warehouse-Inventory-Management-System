using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Models;

namespace Warehouse.Contracts
{
    public interface IProductRepository : IRepository<Product>
    {
        
        IEnumerable<Product> GetProductsByCategory(int categoryId);
        IEnumerable<Product> GetProductsCheaperThan(decimal price);
        int GetMaxId();

    }
}
