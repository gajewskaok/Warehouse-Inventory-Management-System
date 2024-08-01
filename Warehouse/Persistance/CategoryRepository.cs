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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly KioskDbContext _kioskDbContext;
        public CategoryRepository(KioskDbContext context)
        : base(context)
        {
            _kioskDbContext = context;
        }

        public Category GetCategoryWithProducts(int categoryId)
        {
            return _kioskDbContext.Categories
                .Include(c => c.Products)
                .FirstOrDefault(c => c.Id == categoryId);
        }
    }
}
