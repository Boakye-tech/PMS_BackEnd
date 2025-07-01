// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Interfaces/Setup/ISuppliersService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:30 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Facilities.Application.Interfaces.Setup
{
    public interface ISuppliersService
    {
        Task<ReturnResponsesDto> CreateSuppliersAsync(SuppliersCreateDto values);
        Task<ReturnResponsesDto> UpdateSuppliersAsync(SuppliersUpdateDto values);
        Task<IEnumerable<SuppliersReadDto>> GetSuppliersAsync();
        Task<ReturnResponsesDto> DeleteSuppliersAsync(int supplierID);
    }
}