// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Application/Interfaces/Setups/ITransferTypeService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 2:30 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Legal.Application.Dtos;
using Modules.Legal.Application.Dtos.Setups;

namespace Modules.Legal.Application.Interfaces.Setups
{
    public interface ITransferTypeService
    {
        Task<ReturnResponsesDto> CreateTransferTypeAsync(TransferTypeCreateDto values);
        Task<ReturnResponsesDto> UpdateTransferTypeAsync(TransferTypeUpdateDto values);
        Task<ReturnResponsesDto> DeleteTransferType(int transferTypeId);
        Task<IEnumerable<TransferTypeRedDto>> GetTransferTypeAsync();
        Task<IEnumerable<TransferTypeRedDto>> GetTransferTypeAsync(int transferTypeId);

    }
}



