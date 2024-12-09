namespace Modules.Estates.Application.Interfaces.Entities.Setup.Property;

public interface IBlockUnitService
{
    Task<BlockUnitReadDto> AddBlockUnitAsync(BlockUnitCreateDto values);
    Task<BlockUnitReadDto> UpdateBlockUnitAsync(BlockUnitUpdateDto values);
    Task<IEnumerable<BlockUnitReadDto>> GetBlockUnitAsync();
    Task<BlockUnitReadDto> GetBlockUnitAsync(int value);
    Task<BlockUnitReadDto> GetBlockUnitAsync(string value);
}

