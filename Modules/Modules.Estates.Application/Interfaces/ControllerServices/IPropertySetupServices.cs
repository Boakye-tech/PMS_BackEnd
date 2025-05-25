// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/ControllerServices/IPropertySetupServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/05/2025 7:42 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Modules.Estates.Application.Interfaces.ControllerServices
{
	public interface IPropertySetupServices
	{
		// Locality methods
		Task<IEnumerable<LocalityReadDto>> GetLocalityAsync();
		Task<LocalityReadDto> GetLocalityAsync(string value);
		Task<LocalityReadDto> GetLocalityAsync(int localityId);
		Task<ReturnResponsesDto> CreateLocalityAsync(LocalityCreateDto values);
		Task<ReturnResponsesDto> UpdateLocalityAsync(LocalityUpdateDto values);
		Task<ReturnResponsesDto> DeleteLocality(int localityId);

		// Allocation Type methods
		Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync();
		Task<ReturnResponsesDto> CreateAllocationTypeAsync(AllocationTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateAllocationTypeAsync(AllocationTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteAllocationType(int allocationTypeId);

		// Lease Type and Period methods
		Task<IEnumerable<LeaseTypeAndPeriodReadDto>> GetLeaseTypeAndPeriodAsync();
		Task<ReturnResponsesDto> CreateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodCreateDto values);
		Task<ReturnResponsesDto> UpdateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodUpdateDto values);
		Task<ReturnResponsesDto> DeleteLeaseTypeAndPeriod(int leaseTypeAndPeriodId);

		// Currency Exchange Rate methods
		Task<IEnumerable<CurrencyExchangeRateReadDto>> GetCurrencyExchangeRateAsync();
		Task<ReturnResponsesDto> CreateCurrencyExchangeRateAsync(CurrencyExchangeRateCreateDto values);
		Task<ReturnResponsesDto> UpdateCurrencyExchangeRateAsync(CurrencyExchangeRateUpdateDto values);
		Task<ReturnResponsesDto> DeleteCurrencyExchangeRateAsync(int currencyId);

		// Land Use methods
		Task<IEnumerable<LandUseReadDto>> GetLandUseAsync();
		Task<ReturnResponsesDto> CreateLandUseAsync(LandUseCreateDto values);
		Task<ReturnResponsesDto> UpdateLandUseAsync(LandUseUpdateDto values);
		Task<ReturnResponsesDto> DeleteLandUse(int landUseId);

		// Land Use Type methods
		Task<IEnumerable<LandUseTypeReadDto>> GetLandUseTypeAsync();
		Task<ReturnResponsesDto> CreateLandUseTypeAsync(LandUseTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateLandUseTypeAsync(LandUseTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteLandUseType(int landUseTypeId);

		// Land Use and Land Use Type methods
		Task<List<LandUseAndLandUseTypeReadDto>> GetLandUseAndLandUseTypeAsync();
	}
}

