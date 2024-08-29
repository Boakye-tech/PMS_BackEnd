// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Domain/Interfaces/IUnitOfWork.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 12:04 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Documents.Domain.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {
        IFormTemplatesRepository FormTemplates { get; }
        IFormFieldsRepository FormFields { get; }

        Task<int> Complete();
    }
}

