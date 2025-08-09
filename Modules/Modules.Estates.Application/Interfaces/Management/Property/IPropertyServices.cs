// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Presentation
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Management/Property/IPropertyServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 10/05/2025 10:54 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Management.Property
{
    public interface IPropertyServices
    {
        Task<ReturnResponsesDto> StopDebitAsync(StopDebitRequestDto values);

        Task<ReturnResponsesDto> StartDebitAsync(StopDebitRequestDto values);

        Task<ReturnResponsesDto> SwapLocalityAsync(SwapLocalityDto values);

        Task<ReturnResponsesDto> SwapAllocationTypeAsync(SwapAllocationTypeDto values);

        Task<ReturnResponsesDto> SwapLanUseAndLandUseTypeAsync(SwapLandUseAndLandUseTypeDto values);

        Task<ReturnResponsesDto> AssignPropertyToCustomerAsync(AssignPropertytoCustomerDto values);

        //Task<ReturnResponsesDto> AddLeaseDetailsAsync(PropertyLeaseDetailsCreateDto values);

        //Task<ReturnResponsesDto> UpdateLeaseDetailsAsync(PropertyLeaseDetailsUpdateDto values);

        //Task<ReturnResponsesDto> RenewLeaseAsync(PropertyLeaseDetailsRenewDto values);


    }
}

