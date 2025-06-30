// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Interfaces/IUnitOfWork.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 11:56 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Facilities.Domain.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Category { get; }
        ICleanersRepository Cleaners { get; }
        IItemsRepository Items { get; }
        IItemsCategoryRepository ItemsCategory { get; }
        IServiceCategoryRepository ServiceCategory { get; }
        IServiceProvidersRepository ServiceProviders { get; }
        IServicesRepository Services { get; }
        IStockRepository Stock { get; }
        ISuppliersRepository Suppliers { get; }




        Task<int> Complete();
    }
}

