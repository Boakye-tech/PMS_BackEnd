using System;
using Modules.Customers.Application.Dtos;

namespace Modules.Customers.Application.UseCases
{
	public class CustomerDetailsService : ICustomerDetailsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public CustomerDetailsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<GenericResponseDto> AddNewCustomerDetails(CustomerDetailsDto values)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponseDto> DeleteCustomerDetails(string customerCode)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponseDto> UpdateCustomerDetails(CustomerDetailsDto values)
        {
            throw new NotImplementedException();
        }
    }
}

