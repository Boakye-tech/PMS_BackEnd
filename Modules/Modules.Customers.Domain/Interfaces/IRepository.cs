using System;
using System.Linq.Expressions;

namespace Modules.Customers.Domain.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class
    {

        TEntity Get(int id);

        TEntity Get(string name);

        Task<IList<TEntity>> GetAll(
                   Expression<Func<TEntity, bool>>? expression = null,
                   Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                   List<string>? includes = null
                   );

        Task<TEntity> Get(Expression<Func<TEntity, bool>> expression, List<string>? includes = null);

        Task Insert(TEntity entity);

        Task InsertRange(IEnumerable<TEntity> entities);

        Task Delete(TEntity entity);

        Task DeleteRange(IEnumerable<TEntity> entities);

        Task Update(TEntity entity);

        Task UpdateRange(IEnumerable<TEntity> entities);
    }
}

