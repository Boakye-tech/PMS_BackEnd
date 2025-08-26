// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Registration/Property/IPropertyMasterCommandService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/08/2025 12:27 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Interfaces.Registration.Property
{
	public interface IPropertyMasterCommandService
	{
        Task<ReturnResponsesDto> CreateProperty(PropertyMasterCreatePlotDto values);//

        Task<ReturnResponsesDto> CreateApartment(ApartmentCreateDto values);

        Task<ReturnResponsesDto> CreatePlot(PlotCreateDto values);

        Task<ReturnResponsesDto> CreateShopsOffice(ShopOfficeCreateDto values);

        Task<ReturnResponsesDto> CreateHouse(HouseCreateDto values);

        Task<ReturnResponsesDto> CreateRentalHouse(RentalHouseCreateDto values);

        Task<ReturnResponsesDto> CreateLargeScale(largeScaleCreateDto values);

        Task<ReturnResponsesDto> DeletePropertyDetails(string propertyNumber);
    }
}

