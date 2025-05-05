// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

        public async Task<GenericResponseDto> AddNewCustomerDetails(CustomerDetailsDto values)
        {
            //throw new NotImplementedException();
            CustomerDetails customer = CustomerDetails.AddCustomerDetails(0, values.CustomerType, values.ResidentType, values.Locality, values.CustomerCode, values.CustomerName, values.Picture!, values.Gender!, values.Nationality!, values.PostalAddress!, values.ResidentialAddress!,
                                                                          values.DigitalAddress!, values.PrimaryMobileNumber, values.SecondaryMobileNumber!, values.OfficeNumber!, values.WhatsAppNumber!, values.EmailAddress, values.SocialMediaType!, values.SocialMediaAccount!);

            _unitOfWork.CustomerDetails.Insert(customer);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "200" };
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

