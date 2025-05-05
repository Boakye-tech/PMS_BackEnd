// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IBlockNumberService
{
    Task<BlockNumberReadDto> AddBlockNumberAsync(BlockNumberCreateDto values);
    Task<BlockNumberReadDto> UpdateBlockNumberAsync(BlockNumberUpdateDto values);
    Task<IEnumerable<BlockNumberReadDto>> GetBlockNumberAsync();
    Task<BlockNumberReadDto> GetBlockNumberAsync(int value);
    Task<BlockNumberReadDto> GetBlockNumberAsync(string value);
}

