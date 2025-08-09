// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Management/ILeaseService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 09/08/2025 7:16 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Management.Property
{
	public interface ILeaseService
	{
        Task<ReturnResponsesDto> AddLeaseDetailsAsync(PropertyLeaseDetailsCreateDto values);

        Task<ReturnResponsesDto> UpdateLeaseDetailsAsync(PropertyLeaseDetailsUpdateDto values);

        Task<ReturnResponsesDto> RenewLeaseAsync(PropertyLeaseDetailsRenewDto values);
    }
}

