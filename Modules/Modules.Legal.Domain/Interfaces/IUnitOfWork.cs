// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Domain/Interfaces/IUnitOfWork.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 14/09/2025 9:44 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Legal.Domain.Interfaces.Entities;

namespace Modules.Legal.Domain.Interfaces
{
	public interface IUnitOfWork : IDisposable
    {
        ICaseTypeRepository CaseType { get; }
        IConsentTypesRepository ConsentType { get; }
        ICourtsRepository Courts { get; }
        ICourtDivisionsRepository CourtDivisions { get; }
        ITransferTypesRepository TransferTypes { get; }
        IStatusTypesRepository StatusTypes { get; }

        Task<int> Complete();
    }
}

