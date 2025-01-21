using System;

namespace Modules.Customers.Application.UseCases
{
	public class PropertyDetailsService : IPropertyDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;



        public PropertyDetailsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public Task<GenericResponseDto> AddNewPropertyDetails(PropertyDetailsDto values)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponseDto> DeletePropertyDetails(string value)
        {
            throw new NotImplementedException();
        }

        public Task<PropertyDetailsReadDto> GetPropertyDetails(string propertyNumber)
        {
            throw new NotImplementedException();
        }

        public Task<PropertySummaryMobileViewDto> GetPropertySummaryMobile(string customerCode)
        {
            throw new NotImplementedException();
        }

        public Task<PropertySummaryWebViewDto> GetPropertySummaryWeb(string customerCode)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponseDto> UpdatePropertyDetails(PropertyDetailsDto values)
        {
            throw new NotImplementedException();
        }
    }
}

