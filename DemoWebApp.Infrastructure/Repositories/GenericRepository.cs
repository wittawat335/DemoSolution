using DemoWebApp.Core.Domain.RepositoryContracts;
using DemoWebApp.Infrastructure.DBContexts;
using Microsoft.EntityFrameworkCore;
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
        public IQueryable<T> AsQueryable(Expression<Func<T, bool>> filter = null, int? skip = null, int? take = null)
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
        public T Get(Expression<Func<T, bool>> filter)
        {
            return _dbContext.Set<T>().FirstOrDefault(filter);
        }
        public T Find(string code)
        {
            return _dbContext.Set<T>().Find(code);
        }
        public void Insert(T model)
        {
            _dbContext.Set<T>().Add(model);
        }
        public void InsertList(List<T> model)
        {
            _dbContext.Set<T>().AddRange(model);
        }
        public void Update(T model)
        {
            _dbContext.Set<T>().Update(model);
        }
        public void UpdateList(List<T> model)
        {
            _dbContext.Set<T>().UpdateRange(model);
        }
        public void Delete(T model)
        {
            _dbContext.Set<T>().Remove(model);
        }
        public void DeleteList(List<T> model)
        {
            _dbContext.Set<T>().RemoveRange(model);
        }
        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        #region Async
        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
        public async Task<T> GetAsync(Expression<Func<T, bool>> filter)
        {
            return await _dbContext.Set<T>().FirstOrDefaultAsync(filter);
        }
        public async Task<List<T>> GetListAsync(Expression<Func<T, bool>> filter = null, int? skip = null, int? take = null)
        {
            try
            {
                List<T> list = filter == null ? await _dbContext.Set<T>().ToListAsync() : await _dbContext.Set<T>().Where(filter).ToListAsync();

                if (skip != null)
                    list = list.Skip(skip.Value).ToList();

                if (take != null)
                    list = list.Take(take.Value).ToList();

                return list;
            }
            catch
            {
                throw;
            }
        }
        public async Task<T> FindAsync(string code)
        {
            return await _dbContext.Set<T>().FindAsync(code);
        }
        public async Task InsertAsync(T model)
        {
            await _dbContext.Set<T>().AddAsync(model);
        }
        public async Task InsertListAsync(List<T> model)
        {
            await _dbContext.Set<T>().AddRangeAsync(model);
        }

        #endregion
    }
}
