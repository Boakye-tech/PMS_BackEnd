// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Registration/Property/IPropertyMasterService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/07/2025 10:55 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Registration.Property
{
	public interface IPropertyMasterService
	{
        Task<List<PropertyListSummaryViewDto>> GetListOfProperties(string? search = null, int? landUseId = null, int? landUseTypeId = null, int? localityId = null, int? allocationTypeId = null);
        Task<List<PropertyMasterDto>> GetProperties(int localityId);

        ReturnResponsesDto GetAcreage(string plotDimension);
        Task<ReturnResponsesDto> GetAcreage(int plotDimensionId);

        Task<List<largeScaleListDto>> GetLargeScaleListForRegistration();

        Task<ReturnResponsesDto> CreateProperty(PropertyMasterCreatePlotDto values);//

        Task<ReturnResponsesDto> CreateApartment(ApartmentCreateDto values);

        Task<ReturnResponsesDto> CreatePlot(PlotCreateDto values);

        Task<ReturnResponsesDto> CreateShopsOffice(ShopOfficeCreateDto values);

        Task<ReturnResponsesDto> CreateHouse(HouseCreateDto values);

        Task<ReturnResponsesDto> CreateRentalHouse(RentalHouseCreateDto values);

        Task<ReturnResponsesDto> CreateLargeScale(largeScaleCreateDto values);
    }
}

