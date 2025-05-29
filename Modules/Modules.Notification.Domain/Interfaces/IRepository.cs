// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Notification.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Notification.Domain/Interfaces/Repository.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 27/05/2025 1:56 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Linq.Expressions;

namespace Modules.Notification.Domain.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IList<T>> GetAll(
                    Expression<Func<T, bool>>? expression = null,
                    Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
                    List<string>? includes = null
                    );

        Task<T?> Get(Expression<Func<T, bool>> expression, List<string>? includes = null);

        Task Insert(T entity);

        Task InsertRange(IEnumerable<T> entities);

        Task Delete(T entity);

        Task Update(T entity);

        //Task UpdateRange(IEnumerable<T> entities);
    }
}

