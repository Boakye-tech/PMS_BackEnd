// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Customers.Application.Interfaces
{
	public interface IPropertyDetailsService
	{
        Task<GenericResponseDto> AddNewPropertyDetails(PropertyDetailsDto values);
        Task<GenericResponseDto> UpdatePropertyDetails(PropertyDetailsDto values);
        Task<GenericResponseDto> DeletePropertyDetails(string value);
        //Task<GenericResponseDto> DeletePropertyDetails(string cus);

        Task<IEnumerable<PropertySummaryMobileViewDto>> GetPropertySummaryMobile(string customerCode);
        Task<IEnumerable<PropertySummaryWebViewDto>> GetPropertySummaryWeb(string customerCode);

        Task<PropertyDetailsReadDto> GetPropertyDetails(string propertyNumber);

        Task<IEnumerable<AvailablePropertySummaryViewDto>> AvailablePropertiesSummary();
        

    }


}

