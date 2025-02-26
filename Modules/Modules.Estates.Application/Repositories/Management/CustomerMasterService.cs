using System;
using Modules.Estates.Application.DTO.Management;
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

        public async Task<IEnumerable<CustomerListDto>> GetCustomerListAsync()
        {
            //throw new NotImplementedException();

            var customersQuery = from a in await _unitOfWork.CustomerMaster.GetAll()
                                 join b in await _unitOfWork.Title.GetAll()
                                 on a.TitleId equals b.TitleId into titleGroup
                                 from title in titleGroup.DefaultIfEmpty() // Left join on Title

                                 join c in await _unitOfWork.Locality.GetAll()
                                 on a.LocalityId equals c.LocalityId into localityGroup
                                 from locality in localityGroup.DefaultIfEmpty() // Left join on Locality

                                 select new CustomerListDto
                                 {
                                     CustomerCode = a.CustomerCode,
                                     //Title = title != null ? title.Titles : null, // Handle NULL values from left join
                                     //SurName = a.SurName,
                                     //OtherNames = a.OtherNames,
                                     //CompanyName = a.CompanyName,
                                     FullName = string.Concat(title != null ? title.Titles : null, a.SurName, a.OtherNames, a.CompanyName),
                                     Locality = locality != null ? locality.LocalityName : string.Empty, // Handle NULL values from left join
                                     EmailAddress = a.EmailAddress,
                                     PrimaryMobileNumber = a.PrimaryMobileNumber,
                                     DebtorStatus = a.DebtorStatus == 90 ? "STOP DEBIT" : string.Empty 
                                 };

            // Execute asynchronously
            //var customers = customersQuery.ToList();// .ToListAsync();

            //return customers;

            return customersQuery.ToList();

        }


    }
}

