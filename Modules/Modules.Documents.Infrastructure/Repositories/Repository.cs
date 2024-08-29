// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/Repositories/Repository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 1:54 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Modules.Documents.Infrastructure.Repositories
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

        public IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>>? expression = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, List<string>? includes = null)
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

            return query.AsNoTracking();
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

        public void Update(TEntity entity)
        {
            //_dbContext.Set<TEntity>().Update(entity);

            var key = _dbContext.Model.FindEntityType(typeof(TEntity))!
                 .FindPrimaryKey()!
                 .Properties
                 .Select(p => p.PropertyInfo!.GetValue(entity))
                 .ToArray();

            var existingEntity = _dbContext.Set<TEntity>().Find(key);

            if (existingEntity != null)
            {
                _dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
            }
            else
            {
                _dbContext.Attach(entity);
                _dbContext.Entry(entity).State = EntityState.Modified;
            }

        }

        public void UpdateRange(IEnumerable<TEntity> entities) => _dbContext.Set<TEntity>().UpdateRange(entities);





    }
}

