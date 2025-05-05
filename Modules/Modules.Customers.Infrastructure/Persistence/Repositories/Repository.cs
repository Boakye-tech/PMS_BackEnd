// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.EntityFrameworkCore;
using Modules.Customers.Domain.Entities;
using System.Linq;
using System.Linq.Expressions;

namespace Modules.Customers.Infrastructure.Persistence.Repositories
{
	public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Delete(TEntity entity) => _dbContext.Set<TEntity>().Remove(entity);

        public void DeleteRange(IEnumerable<TEntity> entities) => _dbContext.Set<TEntity>().RemoveRange(entities);

        public async Task<TEntity?> Get(int id) => await _dbContext.Set<TEntity>().FindAsync(id);

        public async Task<TEntity?> Get(string name) => await _dbContext.Set<TEntity>().FindAsync(name);

        public async Task<TEntity?> Get(Expression<Func<TEntity, bool>> expression, List<string>? includes = null)
        {
            IQueryable<TEntity> entities = _dbContext.Set<TEntity>();
            if (includes != null)
            {
                foreach (var includeProp in includes)
                {
                    entities = entities.Include(includeProp);
                }
            }

            return await entities.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<TEntity>> GetAll(Expression<Func<TEntity, bool>>? expression = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, List<string>? includes = null)
        {
            IQueryable<TEntity> query = _dbContext.Set<TEntity>();

            if (expression != null)
                query = query.Where(expression);

            if (includes != null)
            {
                foreach (var includeProperty in includes)
                    query = query.Include(includeProperty);
            }

            if (orderBy != null)
                query = orderBy(query);

            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<IList<TEntity>> GetAll() => await _dbContext.Set<TEntity>().ToListAsync();

        public async void Insert(TEntity entity) => await _dbContext.Set<TEntity>().AddAsync(entity);

        public async void InsertRange(IEnumerable<TEntity> entities) => await _dbContext.Set<TEntity>().AddRangeAsync(entities);

        public void Update(TEntity entity) => _dbContext.Set<TEntity>().Update(entity);

        public void UpdateRange(IEnumerable<TEntity> entities) => _dbContext.Set<TEntity>().UpdateRange(entities);

        
    }
}

