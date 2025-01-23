using System;
using Modules.Customers.Application.Dtos;

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
        
    }


}

