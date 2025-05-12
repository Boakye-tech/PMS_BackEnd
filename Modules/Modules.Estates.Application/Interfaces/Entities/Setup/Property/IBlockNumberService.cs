// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Interfaces/Entities/Setup/Property/IBlockNumberService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Modules.Estates.Application.DTO.Setup;
using Modules.Estates.Application.DTO.Setup.Property;

namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IBlockNumberService
{
    Task<ReturnResponsesDto> CreateBlockNumberAsync(BlockNumberCreateDto values);
    Task<ReturnResponsesDto> UpdateBlockNumberAsync(BlockNumberUpdateDto values);
    Task<ReturnResponsesDto> DeleteBlockNumber(int blockNumberId);
    Task<IEnumerable<BlockNumberReadDto>> GetBlockNumberAsync();
    Task<BlockNumberReadDto> GetBlockNumberAsync(int value);
    Task<BlockNumberReadDto> GetBlockNumberAsync(string value);
}

