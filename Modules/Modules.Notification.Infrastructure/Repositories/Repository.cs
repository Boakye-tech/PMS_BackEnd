// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Infrastructure/Repositories/Repository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 27/05/2025 1:59 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Notification.Infrastructure.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly NotificationDbContext _dbContext;
        private readonly DbSet<T> _dbs;

        public Repository(NotificationDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbs = _dbContext.Set<T>();
        }

        public async Task Delete(T entity)
        {
            var _ddbs = _dbs.Attach(entity);
            _ddbs.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T?> Get(Expression<Func<T, bool>> expression, List<string>? includes = null)
        {
            IQueryable<T> query = _dbs;
            if (includes != null)
            {
                foreach (var includeProperty in includes)
                    query = query.Include(includeProperty);
            }
            return await query.AsNoTracking().FirstOrDefaultAsync(expression);
        }

        public async Task<IList<T>> GetAll(Expression<Func<T, bool>>? expression = null, Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null, List<string>? includes = null)
        {
            IQueryable<T> query = _dbs;

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

        public async Task Insert(T entity)
        {
            await _dbs.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task InsertRange(IEnumerable<T> entities)
        {
            await _dbs.AddRangeAsync(entities);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(T entity)
        {
            /*
            var _udbs = _dbs.Attach(entity);
            _udbs.State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            

            var existing = _dbs.Local.FirstOrDefault(e => EF.Property<object>(e, "Id") == EF.Property<object>(entity, "Id"));

            if (existing != null)
            {
                _dbContext.Entry(existing).State = EntityState.Detached;
            }

            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
            */

            // Get the value of the "Id" property from the incoming entity
            var entityId = entity.GetType().GetProperty("Id")?.GetValue(entity);

            if (entityId != null)
            {
                var trackedEntity = _dbs.Local
                    .FirstOrDefault(e =>
                        e.GetType().GetProperty("Id")?.GetValue(e)?.Equals(entityId) == true);

                if (trackedEntity != null)
                {
                    _dbContext.Entry(trackedEntity).State = EntityState.Detached;
                }
            }

            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        
    }
}

