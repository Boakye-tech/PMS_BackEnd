// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Application/UseCases/CustomerOpeningBalancesService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/06/2025 8:57 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Azure;

namespace Modules.Customers.Application.UseCases
{
	public class CustomerOpeningBalancesService : ICustomerOpeningBalancesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerOpeningBalancesService(IUnitOfWork unitOfWork, IMapper mapper)
		{
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GenericResponseDto> AddCustomerOpeningBalance(CustomerOpeningBalancesDto values)
        {
            //throw new NotImplementedException();
            CustomerOpeningBalances openingBalances = CustomerOpeningBalances.AddCustomerOpeningBalances(values.Id, values.PropertyNumber!, values.CustomerCode!, values.AccountCode!, values.OpeningBalance, values.Years);

            _unitOfWork.CustomerOpeningBalances.Insert(openingBalances);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "200" };
        }

        public Task<GenericResponseDto> DeleteCustomerOpeningBalance(int complaintTypeid)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<CustomerOpeningBalancesDto>> GetCustomerOpeningBalances()
        {
            //throw new NotImplementedException();
            var response = await _unitOfWork.CustomerOpeningBalances.GetAll();

            return _mapper.Map<IEnumerable<CustomerOpeningBalancesDto>>(response);
        }

        public async Task<IEnumerable<CustomerOpeningBalancesDto>> GetCustomerOpeningBalances(string customerCode, string propertyNumber, int year)
        {
            //throw new NotImplementedException();

            var balancesQuery = (await _unitOfWork.CustomerOpeningBalances.GetAll()).AsQueryable();

            // Apply filters dynamically based on provided parameters
            if (!string.IsNullOrEmpty(customerCode))
                balancesQuery = balancesQuery.Where(t => t.CustomerCode == customerCode);

            if (!string.IsNullOrEmpty(propertyNumber))
                balancesQuery = balancesQuery.Where(t => t.PropertyNumber == propertyNumber);

            if (!string.IsNullOrEmpty(year.ToString()))
            {
                balancesQuery = balancesQuery.Where(t => t.Years >= year);
            }

            // Order by latest TransactionDate first
            balancesQuery = balancesQuery.OrderByDescending(t => t.Years);

            // Execute the query (fetch from DB)
            var balances = balancesQuery.Select(t => new CustomerOpeningBalancesDto
            {
                CustomerCode = t.CustomerCode,
                PropertyNumber = t.PropertyNumber,
                AccountCode = t.AccountCode,
                OpeningBalance = t.OpeningBalance,
                Years = t.Years

            }).ToList(); // Executes the query

            return balances!;

        }

        public Task<GenericResponseDto> UpdateCustomerOpeningBalance(CustomerOpeningBalancesDto values)
        {
            throw new NotImplementedException();
        }
    }
}

