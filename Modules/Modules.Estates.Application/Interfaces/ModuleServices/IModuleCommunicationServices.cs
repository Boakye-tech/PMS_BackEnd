using System;
using Modules.Estates.Application.DTO.Management.ModuleServices;

namespace Modules.Estates.Application.Interfaces.ModuleServices
{
	public interface IModuleCommunicationServices
	{
        Task<bool> SendIdentificationTypeAsync(IdentificationTypeDto payload);

        Task<bool> SendCustomerDetailsAsync(OnlineCustomerDetailsDto payload);
        Task<bool> SendPropertyDetailsAsync(OnlinePropertyDetailsDto payload);

        Task<bool> SendComplaintTypeDetailsAsync(ComplaintTypeDto payload);
        Task<bool> SendNatureOfComplaintDetailsAsync(NatureOfComplaintDto payload);

        Task<bool> SendComplaintTypeDetailsUpdateAsync(ComplaintTypeDto payload);
        Task<bool> SendNatureOfComplaintDetailsUpdateAsync(NatureOfComplaintDto payload);


    }
}

