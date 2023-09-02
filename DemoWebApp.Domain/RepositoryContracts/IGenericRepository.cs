using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp.Domain.RepositoryContracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IQueryable<T>> AsQueryable(Expression<Func<T, bool>>? filter = null, int? skip = null, int? take = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        void Insert(T model);
        void InsertList(List<T> model);
        void Update(T model);
        void UpdateList(List<T> model);
        void Delete(T model);
        void DeleteList(List<T> model);
        Task SaveChangesAsync();
    }
}
