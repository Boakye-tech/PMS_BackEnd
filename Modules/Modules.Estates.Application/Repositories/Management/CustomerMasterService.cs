using System;
using Modules.Estates.Application.DTO.Management.Customer;
using Modules.Estates.Application.Interfaces.Management.Customer;

namespace Modules.Estates.Application.Repositories.Management
{
	public class CustomerMasterService : ICustomerMasterService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerMasterService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public Task<ProspectiveCustomerResponseDto> CreateCustomer(ProspectiveCustomerDto values)
        {
            throw new NotImplementedException();
        }

        public Task<CompanyCustomerResponseDto> CreateCustomer(CompanyCustomerDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IndividualResidentCustomerResponseDto> CreateCustomer(IndividualResidentCustomerDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IndividualNonResidentCustomerResponseDto> CreateCustomer(IndividualNonResidentCustomerDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IndividualExpatriateCustomerResponseDto> CreateCustomer(IndividualExpatriateCustomerDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<AllocationTypeReadDto>> GetAllocationTypeAsync()
        {
            throw new NotImplementedException();
        }
    }
}

