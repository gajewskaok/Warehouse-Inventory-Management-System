﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Warehouse.Contracts;

namespace Warehouse.Persistance
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly DbContext _context;
        public Repository(DbContext context)
        {
            _context = context;
        }
        public TEntity Get(Guid id)
        {
            return _context.Set<TEntity>().Find(id);
        }
        public IList<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }
        public IList<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression).ToList();
        }
        public void Insert(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }
        public void Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }
    }
}
