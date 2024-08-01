using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Contracts;
using Warehouse.Models;

namespace Warehouse.Persistance
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly KioskDbContext _kioskDbContext;
        public ProductRepository(KioskDbContext context)
        : base(context)
        {
            _kioskDbContext = context;
        }
        public IEnumerable<Product> GetProductsByCategory(int categoryId)
        {
            return _kioskDbContext.Products.Where(p => p.CategoryId == categoryId).ToList();
        }
        public IEnumerable<Product> GetProductsCheaperThan(decimal price)
        {
            return _kioskDbContext.Products.Where(p => p.Price < price).ToList();
        }
        public int GetMaxId()
        {
            return _kioskDbContext.Products.Max(p => p.Id);
        }
    }
}
