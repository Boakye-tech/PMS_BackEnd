﻿using System;
using System.Linq.Expressions;

namespace Modules.Finance.Domain.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);

        Task<IList<TEntity>> GetAll(
                    Expression<Func<TEntity, bool>>? expression = null,
                    Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                    List<string>? includes = null
                    );

        Task<IList<TEntity>> GetAll();

        Task<TEntity> Get(Expression<Func<TEntity, bool>> expression, List<string>? includes = null);

        void Insert(TEntity entity);

        void InsertRange(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);
    }
}

