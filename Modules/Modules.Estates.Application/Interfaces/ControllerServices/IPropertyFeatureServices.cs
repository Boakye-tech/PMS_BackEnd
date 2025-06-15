// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/ControllerServices/IPropertyFeatureServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 24/05/2025 7:41 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Modules.Estates.Application.Interfaces.ControllerServices
{
	public interface IPropertyFeatureServices
	{
		// Features methods
		Task<IEnumerable<FeaturesReadDto>> GetFeaturesAsync();
		Task<ReturnResponsesDto> CreateFeaturesAsync(FeaturesCreateDto values);
		Task<ReturnResponsesDto> UpdateFeaturesAsync(FeaturesUpdateDto values);
		Task<ReturnResponsesDto> DeleteFeatures(int featureId);

		// Apartment Features methods
		Task<IEnumerable<ApartmentFeaturesReadDto>> GetApartmentFeaturesAsync();
		Task<ReturnResponsesDto> CreateApartmentFeaturesAsync(ApartmentFeaturesCreateDto values);
		Task<ReturnResponsesDto> UpdateApartmentFeaturesAsync(ApartmentFeaturesUpdateDto values);
		Task<ReturnResponsesDto> DeleteApartmentFeatures(int apartmentFeatureId);

		// Plot Dimension methods
		Task<IEnumerable<PlotDimensionReadDto>> GetPlotDimensionAsync();
		Task<PlotDimensionReadDto> GetPlotDimensionAsync(string value);
		Task<PlotDimensionReadDto> GetPlotDimensionAsync(int plotDimensionId);
		Task<ReturnResponsesDto> CreatePlotDimensionAsync(PlotDimensionCreateDto values);
		Task<ReturnResponsesDto> UpdatePlotDimensionAsync(PlotDimensionUpdateDto values);
		Task<ReturnResponsesDto> DeletePlotDimension(int plotDimensionId);

		// Apartment Type methods
		Task<IEnumerable<ApartmentTypesReadDto>> GetApartmentTypeAsync();
		Task<ReturnResponsesDto> CreateApartmentTypeAsync(ApartmentTypeCreateDto values);
		Task<ReturnResponsesDto> UpdateApartmentTypeAsync(ApartmentTypeUpdateDto values);
		Task<ReturnResponsesDto> DeleteApartmentType(int apartmentTypeId);

		// Property Type methods
		Task<IEnumerable<PlotTypeReadDto>> GetPlotTypeAsync();
		Task<ReturnResponsesDto> CreatePlotTypeAsync(PlotTypeCreateDto values);
		Task<ReturnResponsesDto> UpdatePlotTypeAsync(PlotTypeUpdateDto values);
		Task<ReturnResponsesDto> DeletePlotType(int PlotTypeId);

		// Property Height methods
		Task<IEnumerable<PropertyHeightReadDto>> GetPropertyHeightAsync();
		Task<ReturnResponsesDto> CreatePropertyHeightAsync(PropertyHeightCreateDto values);
		Task<ReturnResponsesDto> UpdatePropertyHeightAsync(PropertyHeightUpdateDto values);
		Task<ReturnResponsesDto> DeletePropertyHeight(int propertyHeightId);

		// Lease Type and Period methods
		Task<IEnumerable<LeaseTypeAndPeriodReadDto>> GetLeaseTypeAndPeriodAsync();
		Task<ReturnResponsesDto> CreateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodCreateDto values);
		Task<ReturnResponsesDto> UpdateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodUpdateDto values);
		Task<ReturnResponsesDto> DeleteLeaseTypeAndPeriod(int leaseTypeAndPeriodId);
	}
}

