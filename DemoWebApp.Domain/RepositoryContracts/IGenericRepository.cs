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
        Task<IQueryable<T>> AsQueryable(Expression<Func<T, bool>> filter = null, int? skip = null, int? take = null);
        Task<T> Get(Expression<Func<T, bool>> filter);
        T Find(string code);
        bool Insert(T model);
        bool InsertList(List<T> model);
        bool Update(T model);
        bool UpdateList(List<T> model);
        bool Delete(T model);
        bool DeleteList(List<T> model);
        Task SaveChangesAsync();
    }
}
