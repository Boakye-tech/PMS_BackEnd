using System;
using Modules.Estates.Application.DTO.Management.ModuleServices;

namespace Modules.Estates.Application.Interfaces.ModuleServices
{
	public interface IModuleCommunicationServices
	{
        Task<bool> SendIdentificationTypeAsync(IdentificationTypeDto payload);

        Task<bool> SendCustomerDetailsAsync(OnlineCustomerDetailsDto payload);
        Task<bool> SendPropertyDetailsAsync(OnlinePropertyDetailsDto payload);
    }
}

