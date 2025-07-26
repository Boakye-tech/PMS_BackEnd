// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Management/Property/PropertyServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 25/07/2025 11:42 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.UseCases.Management.Property
{
	public class PropertyServices: IPropertyServices
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<CustomerMasterService> _logger;

        public PropertyServices(IUnitOfWork unitOfWork, ILogger<CustomerMasterService> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<int> StopCustomerDebitAsync(StopDebitRequestDto values)
        {
            try
            {
                if (values is null)
                {
                    return 400;
                }

                //check if customer exist
                var customer = await _unitOfWork.CustomerMaster.Get(c => c.CustomerCode == values!.CustomerCode);
                if (customer is null)
                {
                    return 404;
                }

                var debitDetails = new StopDebit
                {
                    StopDebitId = 0,
                    CustomerCode = values!.CustomerCode,
                    PropertyNumber = values.PropertyNumber,
                    DebtorStatus = values.DebtorStatus,
                    Reasons = values.Reasons,
                    ActionBy = values.ActionBy,
                    ActionOn = DateTime.UtcNow
                };

                //update customer master
                customer!.DebtorStatus = 90; //values.DebtorStatus;
                customer.ModifiedBy = values.ActionBy;
                customer.ModifiedOn = DateTime.UtcNow;

                _unitOfWork.CustomerMaster.Update(customer);
                _unitOfWork.StopDebit.Insert(debitDetails);

                await _unitOfWork.Complete();

                return 200;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.ToString());
                return 500;
            }


        }
    }
}

