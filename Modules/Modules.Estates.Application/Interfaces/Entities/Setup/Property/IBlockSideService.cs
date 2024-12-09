namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IBlockSideService
{
    Task<BlockSideReadDto> AddBlockSideAsync(BlockSideCreateDto values);
    Task<BlockSideReadDto> UpdateBlockSideAsync(BlockSideUpdateDto values);
    Task<IEnumerable<BlockSideReadDto>> GetBlockSideAsync();
    Task<BlockSideReadDto> GetBlockSideAsync(int value);
    Task<BlockSideReadDto> GetBlockSideAsync(string value);
}

