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


using Modules.Estates.Domain.Entities.Registration.ViewModels;

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

        Task<ReturnResponsesDto> UnAssignPropertyToCustomerAsync(UnassignPropertyFromCustomerDto values);

        Task<List<CustomerToAssignListDto>> GetCustomersToAssign(string? search, string? locality, int pageNumber, int pageSize);

        Task<PropertyMasterViewDto> GetPropertyMasterDetails(string propertyNumber);

        Task<ReturnResponsesDto> UpdateCadastralAndSitePlan(UpdateCadastralAndSitePlanDto values);

        Task<ReturnResponsesDto> UpdateDebtorTypeAndGroupNumber(UpdateDebtorTypeAndGroupNumberDto values);

        Task<ReturnResponsesDto> UpdatePricesFeesAndDates(UpdatePriceFeeAndDatesDto values);


    }
}

