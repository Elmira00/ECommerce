using Ecommerce.Core.Abstraction;
using System.Linq.Expressions;

namespace Ecommerce.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //x=>x.Id==10
        Task<T> Get(Expression<Func<T, bool>> filter);
        Task<List<T>> GetList(Expression<Func<T, bool>> filter = null);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}