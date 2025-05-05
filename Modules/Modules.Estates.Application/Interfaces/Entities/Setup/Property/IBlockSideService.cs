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

public interface IBlockSideService
{
    Task<BlockSideReadDto> AddBlockSideAsync(BlockSideCreateDto values);
    Task<BlockSideReadDto> UpdateBlockSideAsync(BlockSideUpdateDto values);
    Task<IEnumerable<BlockSideReadDto>> GetBlockSideAsync();
    Task<BlockSideReadDto> GetBlockSideAsync(int value);
    Task<BlockSideReadDto> GetBlockSideAsync(string value);
}

