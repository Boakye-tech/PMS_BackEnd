// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Registration/Property/IPropertyMasterQueryService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/08/2025 12:26 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Registration.Property
{
	public interface IPropertyMasterQueryService
	{
        Task<List<PropertyListSummaryViewDto>> GetListOfProperties(string? search = null, int? landUseId = null, int? landUseTypeId = null, int? localityId = null, int? allocationTypeId = null);
        Task<List<PropertyMasterDto>> GetProperties(int localityId);

        ReturnResponsesDto GetAcreage(string plotDimension);
        Task<ReturnResponsesDto> GetAcreage(int plotDimensionId);

        Task<List<largeScaleListDto>> GetLargeScaleListForRegistration();

        Task<PropertyMasterReadDto> GetPropertyDetails(string propertyNumber);
    }
}

