using DemoWebApp.Domain.RepositoryContracts;
using DemoWebApp.Infrastructure.DBContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DemoWebApp.Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly NCLS_SITContext _dbContext;

        public GenericRepository(NCLS_SITContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IQueryable<T>> AsQueryable(Expression<Func<T, bool>> filter = null, int? skip = null, int? take = null)
        {
            try
            {
                IQueryable<T> query = filter == null ? _dbContext.Set<T>() : _dbContext.Set<T>().Where(filter);

                if (skip != null)
                    query = query.Skip(skip.Value);

                if (take != null)
                    query = query.Take(take.Value);

                return query;
            }
            catch
            {
                throw;
            }
        }

        public async Task<T> Get(Expression<Func<T, bool>> filter)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(filter);
        }
        public T Find(string code)
        {
            return _dbContext.Set<T>().Find(code);
        }

        public bool Insert(T model)
        {
            _dbContext.Set<T>().Add(model);
            return true;
        }

        public bool InsertList(List<T> model)
        {
            _dbContext.Set<T>().AddRange(model);
            return true;
        }

        public bool Update(T model)
        {
            _dbContext.Set<T>().Update(model);
            return true;
        }

        public bool UpdateList(List<T> model)
        {
            _dbContext.Set<T>().UpdateRange(model);
            return true;
        }

        public bool Delete(T model)
        {
            _dbContext.Set<T>().Remove(model);
            return true;
        }

        public bool DeleteList(List<T> model)
        {
            _dbContext.Set<T>().RemoveRange(model);
            return true;
        }
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
