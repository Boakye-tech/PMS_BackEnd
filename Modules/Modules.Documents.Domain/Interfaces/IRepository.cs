// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Interfaces/IRepository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 12:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Linq.Expressions;
using Modules.Documents.Domain.Common;

namespace Modules.Documents.Domain.Interfaces
{
	public interface IRepository<TEntity> where TEntity : class
    {

        Task<TEntity?> Get(int id);

        IQueryable<TEntity> GetQueryable(Expression<Func<TEntity, bool>>? expression = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null, List<string>? includes = null);

        Task<IList<TEntity>> GetAll(Expression<Func<TEntity, bool>>? expression = null,Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,List<string>? includes = null);

        Task<IList<TEntity>> GetAll();

        Task<TEntity?> Get(Expression<Func<TEntity, bool>> expression, List<string>? includes = null);

        void Insert(TEntity entity);

        void InsertRange(IEnumerable<TEntity> entities);

        void Delete(TEntity entity);

        void DeleteRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);

        void UpdateRange(IEnumerable<TEntity> entities);


    }
}

